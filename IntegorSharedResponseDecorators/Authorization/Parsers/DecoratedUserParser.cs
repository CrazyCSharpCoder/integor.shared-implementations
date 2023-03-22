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

	public class DecoratedUserParser : IDecoratedObjectParser<JsonElement>
	{
		public ResponseObjectDecorationResult ParseDecorated(JsonElement decoratedObject)
		{
			JsonSerializerOptions options = new JsonSerializerOptions()
			{
				PropertyNameCaseInsensitive = true
			};

			UserDecorationWrapper? userWrapper =
				decoratedObject.Deserialize<UserDecorationWrapper>(options);

			if (userWrapper?.User == null)
				return new ResponseObjectDecorationResult(false);

			return new ResponseObjectDecorationResult(userWrapper.User);
		}
	}
}
