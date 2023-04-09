using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorResponseDecoration;
using IntegorPublicDto.Authorization.Roles;

namespace IntegorSharedResponseDecorators.Authorization.Decorators
{
	using Internal;

    public class UserRolesEnumerableResponseObjectDecorator : IResponseObjectDecorator
    {
        public ResponseObjectDecorationResult Decorate(object? responseObject)
        {
            if (responseObject is not IEnumerable<UserRoleFullDto> roles)
            {
                return new ResponseObjectDecorationResult(false);
            }

			UserRolesEnumerableDecorationWrapper rolesWrapper = new UserRolesEnumerableDecorationWrapper()
			{
				Roles = roles
			};

            return new ResponseObjectDecorationResult(rolesWrapper);
        }
    }
}
