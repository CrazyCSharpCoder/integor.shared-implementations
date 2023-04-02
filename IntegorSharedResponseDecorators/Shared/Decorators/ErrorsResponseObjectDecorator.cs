using System.Collections.Generic;
using System.Linq;

using IntegorErrorsHandling;
using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Shared.Decorators
{
    public class ErrorsResponseObjectDecorator : IResponseObjectDecorator
    {
        private IResponseErrorsObjectCompiler _errorCompiler;

        public ErrorsResponseObjectDecorator(IResponseErrorsObjectCompiler errorCompiler)
        {
            _errorCompiler = errorCompiler;
        }

        public ResponseObjectDecorationResult Decorate(object? responseObject)
        {
            if (responseObject == null)
                return new ResponseObjectDecorationResult(false);

            IEnumerable<IErrorConvertationResult> errors;

            if (responseObject is IEnumerable<IErrorConvertationResult> bodyErrors)
                errors = bodyErrors;
            else if (responseObject is IErrorConvertationResult bodyError)
                errors = new IErrorConvertationResult[] { bodyError };
            else
                return new ResponseObjectDecorationResult(false);

            object errorsBody = _errorCompiler.CompileResponse(errors.ToArray());

            return new ResponseObjectDecorationResult(errorsBody);
        }
    }
}
