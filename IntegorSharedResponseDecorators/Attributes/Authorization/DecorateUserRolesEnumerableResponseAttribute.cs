using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Attributes.Authorization
{
	using Decorators.Authorization;

	public class DecorateUserRolesEnumerableResponseAttribute : ResponseBodyDecorationFilterFactory
	{
        public DecorateUserRolesEnumerableResponseAttribute()
            : base(typeof(UserRolesCollectionResponseBodyDecorator))
        {
        }
    }
}
