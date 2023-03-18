using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorSharedResponseDecorators.Attributes.Authorization
{
	using Decorators.Authorization;

	public class DecorateUserRolesCollectionResponseAttribute : DecorateErrorResponseAttribute
    {
        public DecorateUserRolesCollectionResponseAttribute()
            : base(typeof(UserRolesCollectionResponseBodyDecorator), typeof(UserRolesCollectionResponseBodyDecorator))
        {
        }
    }
}
