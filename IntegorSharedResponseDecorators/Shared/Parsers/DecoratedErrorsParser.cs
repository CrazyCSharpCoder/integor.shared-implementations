﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorErrorsHandling;
using IntegorResponseDecoration.Parsing;

namespace IntegorSharedResponseDecorators.Shared.Parsers
{
	public class DecoratedErrorsParser :
		DecoratedObjectParserBase<IEnumerable<IResponseError>>,
		IDecoratedObjectParser<IEnumerable<IResponseError>, JsonElement>
	{
		private IHttpErrorObjectParser<JsonElement> _errorsParser;

		public DecoratedErrorsParser(IHttpErrorObjectParser<JsonElement> errorsParser)
        {
			_errorsParser = errorsParser;
        }

        public DecoratedObjectParsingResult<IEnumerable<IResponseError>> ParseDecorated(JsonElement decoratedObject)
		{
			IEnumerable<IResponseError>? errors = _errorsParser.GetErrors(decoratedObject);

			if (errors == null)
				return Result(false);

			return Result(errors);
		}
	}
}
