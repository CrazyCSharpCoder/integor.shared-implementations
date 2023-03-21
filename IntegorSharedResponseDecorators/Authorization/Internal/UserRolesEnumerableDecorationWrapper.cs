using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Roles;

namespace IntegorSharedResponseDecorators.Authorization.Internal
{
	internal class UserRolesEnumerableDecorationWrapper
	{
		public IEnumerable<UserRoleFullDto> Roles { get; set; } = null!;
	}
}
