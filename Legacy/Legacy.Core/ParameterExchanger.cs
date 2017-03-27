using System.Collections.Generic;
using System.Linq.Expressions;

namespace Legacy.Core
{
    public class ParameterExchanger : ExpressionVisitor
    {
        private Dictionary<ParameterExpression, Expression> replacements;

        public ParameterExchanger(Dictionary<ParameterExpression, Expression> replacements)
        {
            this.replacements = replacements;
        }

        protected override Expression VisitParameter(ParameterExpression originalParameter)
        {
            Expression replacementExpression;
            return replacements.TryGetValue(originalParameter, out replacementExpression) ? replacementExpression : originalParameter;
        }
    }
}
