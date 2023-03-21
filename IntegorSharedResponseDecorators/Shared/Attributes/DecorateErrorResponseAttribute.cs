using System;
using System.Linq;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Shared.Attributes
{
    using Decorators;

    public class DecorateErrorResponseAttribute : ResponseObjectDecorationFilterFactory
    {
        public DecorateErrorResponseAttribute()
            : base(typeof(ErrorResponseObjectDecorator))
        {
        }
    }
}
