using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorErrorsHandling;
using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Shared.Parsers
{
	public class DecoratedErrorsParser : IDecoratedObjectParser<JsonElement>
	{
		private IHttpErrorObjectParser<JsonElement> _errorsParser;

		public DecoratedErrorsParser(IHttpErrorObjectParser<JsonElement> errorsParser)
        {
			_errorsParser = errorsParser;
        }

        public ResponseObjectDecorationResult ParseDecorated(JsonElement decoratedObject)
		{
			IEnumerable<IResponseError>? errors = _errorsParser.GetErrors(decoratedObject);

			if (errors == null)
				return new ResponseObjectDecorationResult(false);

			return new ResponseObjectDecorationResult(errors);
		}
	}
}
