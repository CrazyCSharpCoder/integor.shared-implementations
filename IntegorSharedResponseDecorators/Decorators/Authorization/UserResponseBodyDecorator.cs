using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Users;
using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Decorators.Authorization
{
    public class UserResponseBodyDecorator : IResponseBodyDecorator
    {
        public ResponseBodyDecorationResult Decorate(object? bodyObject)
        {
            if (bodyObject is not UserAccountInfoDto)
                return new ResponseBodyDecorationResult(false);

            object newBody = new
            {
                user = bodyObject
            };

            return new ResponseBodyDecorationResult(newBody);
        }
    }
}
