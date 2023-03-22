using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorPublicDto.Authorization.Users;
using IntegorResponseDecoration.Parsing;

namespace IntegorSharedResponseDecorators.Authorization.Parsers
{
	using Internal;

	public class DecoratedUserParser :
		DecoratedObjectParserBase<UserAccountInfoDto>,
		IDecoratedObjectParser<UserAccountInfoDto, JsonElement>
	{
		public DecoratedObjectParsingResult<UserAccountInfoDto> ParseDecorated(JsonElement decoratedObject)
		{
			JsonSerializerOptions options = new JsonSerializerOptions()
			{
				PropertyNameCaseInsensitive = true
			};

			UserDecorationWrapper? userWrapper =
				decoratedObject.Deserialize<UserDecorationWrapper>(options);

			if (userWrapper?.User == null)
				return Result(false);

			return Result(userWrapper.User);
		}
	}
}
