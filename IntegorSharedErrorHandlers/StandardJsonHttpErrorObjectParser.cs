using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json;

using IntegorErrorsHandling;
using IntegorErrorsHandling.ExtensibleError;

namespace IntegorSharedErrorHandlers
{
    public class StandardJsonHttpErrorObjectParser : IHttpErrorObjectParser<JsonElement>
	{
		private IErrorParser<JsonError, JsonElement> _errorParser;

		public StandardJsonHttpErrorObjectParser(IErrorParser<JsonError, JsonElement> errorParser)
        {
			_errorParser = errorParser;
        }

		public IEnumerable<IResponseError>? GetErrors(JsonElement responseObject)
		{
			// TODO try pass fake collection object to check stability
			JsonProperty? errorsProp = responseObject.EnumerateObject().FirstOrDefault(prop => prop.Name.ToLower() == "errors");

			if (errorsProp == null)
				return null;

			IEnumerable<JsonElement> errorElements = ((JsonProperty)errorsProp).Value.EnumerateArray();
			List<JsonError> errorsResult = new List<JsonError>();

			foreach (JsonElement errorElement in errorElements)
			{
				JsonError? error = _errorParser.ParseError(errorElement);

				if (error != null)
					errorsResult.Add(error);
			}

			return errorsResult;
		}
	}
}
