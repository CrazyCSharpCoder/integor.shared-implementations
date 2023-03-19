using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Users;
using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Decorators.Authorization
{
    public class UserResponseBodyDecorator : IResponseObjectDecorator
	{
        public ResponseBodyDecorationResult Decorate(object? responseObject)
        {
            if (responseObject is not UserAccountInfoDto)
                return new ResponseBodyDecorationResult(false);

            object newBody = new
            {
                user = responseObject
            };

            return new ResponseBodyDecorationResult(newBody);
        }
    }
}
