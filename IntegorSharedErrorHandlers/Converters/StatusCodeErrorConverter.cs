using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.WebUtilities;

using IntegorErrorsHandling;
using IntegorErrorsHandling.Converters;

namespace IntegorSharedErrorHandlers.Converters
{
	public class StatusCodeErrorConverter : ConverterBase, IErrorConverter<int>
	{
		public IErrorConvertationResult? Convert(int statusCode)
		{
			string message = ReasonPhrases.GetReasonPhrase(statusCode);

			if (string.IsNullOrEmpty(message))
				return null;

			return Single(message);
		}
	}
}
