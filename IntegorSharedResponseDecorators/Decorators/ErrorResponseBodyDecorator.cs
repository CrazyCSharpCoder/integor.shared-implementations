using System.Collections.Generic;
using System.Linq;

using IntegorErrorsHandling;
using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Decorators
{
	public class ErrorResponseBodyDecorator : IResponseObjectDecorator
	{
		private IResponseErrorObjectCompiler _errorCompiler;

		public ErrorResponseBodyDecorator(IResponseErrorObjectCompiler errorCompiler)
		{
			_errorCompiler = errorCompiler;
		}

		public ResponseBodyDecorationResult Decorate(object? responseObject)
		{
			if (responseObject == null)
				return new ResponseBodyDecorationResult(false);

			IEnumerable<IErrorConvertationResult> errors;

			if (responseObject is IEnumerable<IErrorConvertationResult> bodyErrors)
				errors = bodyErrors;
			else if (responseObject is IErrorConvertationResult bodyError)
				errors = new IErrorConvertationResult[] { bodyError };
			else
				return new ResponseBodyDecorationResult(false);

			object errorsBody = _errorCompiler.CompileResponse(errors.ToArray());

			return new ResponseBodyDecorationResult(errorsBody);
		}
	}
}
