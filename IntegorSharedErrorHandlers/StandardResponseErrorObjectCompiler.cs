using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using IntegorErrorsHandling;
using IntegorErrorsHandling.ErrorReading;
using IntegorErrorsHandling.ExtensibleError;

namespace IntegorSharedErrorHandlers
{
	public class StandardResponseErrorObjectCompiler : IResponseErrorObjectCompiler
	{
		private IErrorReader<ExtensibleResponseError> _errorReader;

		public StandardResponseErrorObjectCompiler(IErrorReader<ExtensibleResponseError> errorReader)
        {
			_errorReader = errorReader;
        }

        public object CompileResponse(params IErrorConvertationResult[] errors)
		{
			IEnumerable<object> errorsList = errors.SelectMany(error => error
					.GetErrors().Select(error => error.ToResponseObject()));

			return new { errors = errorsList.ToArray() };
		}

		public IEnumerable<IResponseError>? GetErrors(object responseObject)
		{
			PropertyInfo? errorsProp = responseObject.GetType()
				.GetProperties()
				.FirstOrDefault(prop => prop.Name.ToLower() == "errors");

			if (errorsProp == null)
				return null;

			IEnumerable<object>? errors = errorsProp.GetValue(responseObject) as IEnumerable<object>;

			if (errors == null)
				return null;

			return errors.Select(error => _errorReader.ReadError(error));
		}
	}
}
