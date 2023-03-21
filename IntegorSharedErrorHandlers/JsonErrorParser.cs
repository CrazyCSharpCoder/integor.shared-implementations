using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorErrorsHandling;
using IntegorErrorsHandling.ExtensibleError;

namespace IntegorSharedErrorHandlers
{
    public class JsonErrorParser : IErrorParser<JsonError, JsonElement>
	{
		public JsonError? ParseError(JsonElement errorObject)
		{
			return new JsonError(errorObject);
		}
	}
}
