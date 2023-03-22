using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using IntegorErrorsHandling;

namespace IntegorSharedErrorHandlers
{
	public class StandardResponseErrorObjectCompiler : IResponseErrorObjectCompiler
	{
		public object CompileResponse(params IResponseError[] errors)
		{
			IEnumerable<object> errorResponseObjects = errors.Select(error => error.ToResponseObject());
			return ErrorResponseObjectsToResponse(errorResponseObjects);
		}

		public object CompileResponse(params IErrorConvertationResult[] errors)
		{
			IEnumerable<IResponseError> errorsList = errors.SelectMany(error => error.GetErrors());
			IEnumerable<object> errorResponseObjects = ErrorsToResponseObjects(errorsList).ToArray();

			return ErrorResponseObjectsToResponse(errorResponseObjects);
		}

		private IEnumerable<object> ErrorsToResponseObjects(IEnumerable<IResponseError> errors)
			=> errors.Select(error => error.ToResponseObject());

		private object ErrorResponseObjectsToResponse(IEnumerable<object> errorObjects)
		{
			return new { Errors = errorObjects };
		}
	}
}
