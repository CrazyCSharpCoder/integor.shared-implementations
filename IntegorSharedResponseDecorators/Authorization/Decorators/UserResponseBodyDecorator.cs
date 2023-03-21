using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Users;
using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Authorization.Decorators
{
	using Internal;

    public class UserResponseBodyDecorator : IResponseObjectDecorator
    {
        public ResponseObjectDecorationResult Decorate(object? responseObject)
        {
            if (responseObject is not UserAccountInfoDto user)
                return new ResponseObjectDecorationResult(false);

            UserDecorationWrapper userWrapper = new UserDecorationWrapper()
			{
                User = user
            };

            return new ResponseObjectDecorationResult(userWrapper);
        }
    }
}
