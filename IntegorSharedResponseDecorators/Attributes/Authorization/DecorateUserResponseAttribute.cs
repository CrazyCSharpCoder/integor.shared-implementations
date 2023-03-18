using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorSharedResponseDecorators.Attributes.Authorization
{
	using Decorators.Authorization;

    public class DecorateUserResponseAttribute : DecorateErrorResponseAttribute
    {
        public DecorateUserResponseAttribute()
            : base(typeof(UserResponseBodyDecorator), typeof(UserResponseBodyDecorator))
        {
        }
    }
}
