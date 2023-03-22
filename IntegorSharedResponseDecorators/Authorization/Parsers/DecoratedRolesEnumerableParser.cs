using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorPublicDto.Authorization.Roles;
using IntegorResponseDecoration.Parsing;

namespace IntegorSharedResponseDecorators.Authorization.Parsers
{
	using Internal;

	partial class DecoratedRolesEnumerableParser :
		DecoratedObjectParserBase<IEnumerable<UserRoleFullDto>>,
		IDecoratedObjectParser<IEnumerable<UserRoleFullDto>, JsonElement>
	{
		public DecoratedObjectParsingResult<IEnumerable<UserRoleFullDto>> ParseDecorated(JsonElement decoratedObject)
		{
			UserRolesEnumerableDecorationWrapper? rolesWrapper =
				decoratedObject.Deserialize<UserRolesEnumerableDecorationWrapper>();

			if (rolesWrapper?.Roles == null)
				return Result(false);

			return Result(rolesWrapper.Roles);
		}
	}
}
