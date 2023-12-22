using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Users;

namespace IntegorSharedResponseDecorators.Authorization.Internal
{
	internal class UserDecorationWrapper
	{
		public UserAccountInfoDto User { get; set; } = null!;
	}
}
