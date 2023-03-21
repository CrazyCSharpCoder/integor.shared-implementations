using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Authorization.Attributes
{
    using Decorators;

    public class DecorateUserResponseAttribute : ResponseObjectDecorationFilterFactory
    {
        public DecorateUserResponseAttribute() : base(typeof(UserResponseBodyDecorator))
        {
        }
    }
}
