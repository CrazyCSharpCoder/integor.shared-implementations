using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorResponseDecoration;
using IntegorPublicDto.Authorization.Roles;

namespace IntegorSharedResponseDecorators.Decorators.Authorization
{
    public class UserRolesCollectionResponseBodyDecorator : IResponseBodyDecorator
    {
        public ResponseBodyDecorationResult Decorate(object? bodyObject)
        {
            if (bodyObject is not IEnumerable<UserRoleFullDto> &&
                bodyObject is not IEnumerable<UserRoleShortDto>)
            {
                return new ResponseBodyDecorationResult(false);
            }

            object newBody = new
            {
                roles = bodyObject
            };

            return new ResponseBodyDecorationResult(newBody);
        }
    }
}
