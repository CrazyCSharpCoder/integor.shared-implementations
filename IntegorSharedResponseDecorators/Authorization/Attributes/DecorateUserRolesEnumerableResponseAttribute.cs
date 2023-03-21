using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Authorization.Attributes
{
    using Decorators;

    public class DecorateUserRolesEnumerableResponseAttribute : ResponseObjectDecorationFilterFactory
    {
        public DecorateUserRolesEnumerableResponseAttribute()
            : base(typeof(UserRolesEnumerableResponseBodyDecorator))
        {
        }
    }
}
