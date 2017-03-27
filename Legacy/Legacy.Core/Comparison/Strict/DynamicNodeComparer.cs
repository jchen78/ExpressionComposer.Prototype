using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Dynamic;

namespace Legacy.Core.Comparison.Strict
{
    public class DynamicNodeComparer : INodeComparerForType
    {
        public ExpressionType NodeType => ExpressionType.Dynamic;

        public ComparisonResult AreEqual(IComparisonEffector childrenComparer, Expression leftExpression, Expression rightExpression)
        {
            DynamicExpression
                left = (DynamicExpression)leftExpression,
                right = (DynamicExpression)rightExpression;

            if (left.Arguments.Count != right.Arguments.Count)
                return ComparisonResult.NotEqual;

            for (int i = 0; i < left.Arguments.Count; i++)
                if (childrenComparer.Compare(left.Arguments[i], right.Arguments[i]) == ComparisonResult.NotEqual)
                    return ComparisonResult.NotEqual;
            
            return
                AreBindersEqual(left.Binder, right.Binder) ?
                ComparisonResult.PartiallyEqual :
                ComparisonResult.NotEqual;
        }

        private bool AreBindersEqual(CallSiteBinder left, CallSiteBinder right)
        {
            // WARNING: Lots of untested code!
            // Any code here should be assumed untested unless comparison clause is explicitly described otherwise.

            if (left.GetType() != right.GetType())
                return false;

            var leftDynamicMetaObject = left as DynamicMetaObjectBinder;
            if (leftDynamicMetaObject != null && leftDynamicMetaObject.ReturnType != ((DynamicMetaObjectBinder)right).ReturnType)
                return false;

            var leftBinaryOperation = left as BinaryOperationBinder;
            if (leftBinaryOperation != null)
                return leftBinaryOperation.Operation == ((BinaryOperationBinder)right).Operation; // Tested

            var leftConvert = left as ConvertBinder;
            if (leftConvert != null)
                return
                    leftConvert.Explicit == ((ConvertBinder)right).Explicit;

            var leftCreateInstance = left as CreateInstanceBinder;
            if (leftCreateInstance != null)
                return AreCallInfoSequentiallyEqual(leftCreateInstance.CallInfo, ((CreateInstanceBinder)right).CallInfo);

            var leftDeleteIndex = left as DeleteIndexBinder;
            if (leftDeleteIndex != null)
                return AreCallInfoSequentiallyEqual(leftDeleteIndex.CallInfo, ((DeleteIndexBinder)right).CallInfo);

            var leftDeleteMember = left as DeleteMemberBinder;
            if (leftDeleteMember != null)
            {
                var rightDeleteMember = (DeleteMemberBinder)right;
                return
                    leftDeleteMember.IgnoreCase == rightDeleteMember.IgnoreCase
                    && leftDeleteMember.Name == rightDeleteMember.Name; // NOTE: Because of strict mode, the name HAS to match exactly, regardless of IgnoreCase.
            }

            var leftGetIndex = left as GetIndexBinder;
            if (leftGetIndex != null)
                return AreCallInfoSequentiallyEqual(leftGetIndex.CallInfo, ((GetIndexBinder)right).CallInfo); // Tested

            var leftGetMember = left as GetMemberBinder;
            if (leftGetMember != null)
            {
                var rightGetMember = (GetMemberBinder)right;
                return
                    leftGetMember.IgnoreCase == rightGetMember.IgnoreCase
                    && leftGetMember.Name == rightGetMember.Name;
            }

            var leftInvoke = left as InvokeBinder;
            if (leftInvoke != null)
                return AreCallInfoSequentiallyEqual(leftInvoke.CallInfo, ((InvokeBinder)right).CallInfo);

            var leftInvokeMember = left as InvokeMemberBinder;
            if (leftInvokeMember != null)
            {
                var rightInvokeMember = (InvokeMemberBinder)right;
                return
                    leftInvokeMember.IgnoreCase == rightInvokeMember.IgnoreCase
                    && leftInvokeMember.Name == rightInvokeMember.Name
                    && AreCallInfoSequentiallyEqual(leftInvokeMember.CallInfo, rightInvokeMember.CallInfo);
            }

            var leftSetIndex = left as SetIndexBinder;
            if (leftSetIndex != null)
                return AreCallInfoSequentiallyEqual(leftSetIndex.CallInfo, ((SetIndexBinder)right).CallInfo);

            var leftSetMember = left as SetMemberBinder;
            if (leftSetMember != null)
            {
                var rightSetMember = (SetMemberBinder)right;
                return
                    leftSetMember.IgnoreCase == rightSetMember.IgnoreCase
                    && leftSetMember.Name == rightSetMember.Name;
            }

            var leftUnaryOperation = left as UnaryOperationBinder;
            if (leftUnaryOperation != null)
                return leftUnaryOperation.Operation == ((UnaryOperationBinder)right).Operation;

            throw new NotImplementedException();
        }

        protected bool AreCallInfoSequentiallyEqual(CallInfo left, CallInfo right)
        {
            // NOTE: The code below is insufficiently tested.
            if (left.ArgumentCount != right.ArgumentCount)
                return false;

            for (int i = 0; i < left.ArgumentCount; i++)
                if (left.ArgumentNames[i] != right.ArgumentNames[i])
                    return false;

            return true;
        }
    }
}