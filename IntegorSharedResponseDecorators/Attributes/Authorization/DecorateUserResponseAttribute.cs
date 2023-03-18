using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorSharedResponseDecorators.Attributes.Authorization
{
	using Decorators.Authorization;
	using IntegorResponseDecoration;

    public class DecorateUserResponseAttribute : ResponseBodyDecorationFilterFactory
	{
        public DecorateUserResponseAttribute()
            : base(typeof(UserResponseBodyDecorator), typeof(UserResponseBodyDecorator))
        {
        }
    }
}
