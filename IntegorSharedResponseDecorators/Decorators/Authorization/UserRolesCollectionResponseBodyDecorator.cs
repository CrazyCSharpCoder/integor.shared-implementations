using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorResponseDecoration;
using IntegorPublicDto.Authorization.Roles;

namespace IntegorSharedResponseDecorators.Decorators.Authorization
{
    public class UserRolesCollectionResponseBodyDecorator : IResponseObjectDecorator
	{
        public ResponseBodyDecorationResult Decorate(object? responseObject)
        {
            if (responseObject is not IEnumerable<UserRoleFullDto> &&
                responseObject is not IEnumerable<UserRoleShortDto>)
            {
                return new ResponseBodyDecorationResult(false);
            }

            object newBody = new
            {
                roles = responseObject
            };

            return new ResponseBodyDecorationResult(newBody);
        }
    }
}
