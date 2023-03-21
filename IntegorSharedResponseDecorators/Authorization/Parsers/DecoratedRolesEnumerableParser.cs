using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Authorization.Parsers
{
	using Internal;

	partial class DecoratedRolesEnumerableParser : IDecoratedObjectParser<JsonElement>
	{
		public ResponseObjectDecorationResult ParseDecorated(JsonElement decoratedObject)
		{
			UserRolesEnumerableDecorationWrapper? rolesWrapper =
				decoratedObject.Deserialize<UserRolesEnumerableDecorationWrapper>();

			if (rolesWrapper == null)
				return new ResponseObjectDecorationResult(false);

			return new ResponseObjectDecorationResult(rolesWrapper.Roles);
		}
	}
}
