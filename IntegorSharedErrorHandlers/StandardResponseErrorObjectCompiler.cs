﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using IntegorErrorsHandling;
using IntegorErrorsHandling.ExtensibleError;

namespace IntegorSharedErrorHandlers
{
	public class StandardResponseErrorObjectCompiler : IResponseErrorObjectCompiler
	{
        public object CompileResponse(params IErrorConvertationResult[] errors)
		{
			IEnumerable<object> errorsList = errors.SelectMany(error => error
					.GetErrors().Select(error => error.ToResponseObject()));

			return new { errors = errorsList.ToArray() };
		}
	}
}
