using System;
using System.Linq;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Shared.Attributes
{
    using Decorators;

    public class DecorateErrorsResponseAttribute : ResponseObjectDecorationFilterFactory
    {
        public DecorateErrorsResponseAttribute()
            : base(typeof(ErrorsResponseObjectDecorator))
        {
        }
    }
}
