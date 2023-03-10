using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorErrorsHandling;
using IntegorErrorsHandling.Converters;

using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IntegorSharedErrorHandlers.Converters
{
	public class ModelStateDictionaryErrorConverter : ConverterBase, IErrorConverter<ModelStateDictionary>
	{
		public IErrorConvertationResult? Convert(ModelStateDictionary modelState)
		{
			IEnumerable<IResponseError> errors = modelState
				.Select(pair => NewError(pair.Key, RetrieveErrorMessages(pair.Value.Errors)).Build());

			return Multiple(errors.ToArray());
		}

		private IEnumerable<string> RetrieveErrorMessages(IEnumerable<ModelError> errors)
			=> errors.Select(error => error.ErrorMessage);
	}
}
