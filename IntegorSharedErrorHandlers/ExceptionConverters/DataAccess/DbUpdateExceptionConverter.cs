﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Npgsql;

using IntegorErrorsHandling;
using IntegorErrorsHandling.Converters;
using IntegorErrorsHandling.ExceptionsHandling;

namespace IntegorSharedErrorHandlers.ExceptionConverters.DataAccess
{
	public class DbUpdateExceptionConverter : LazyInjectableExceptionConverter, IExceptionErrorConverter<DbUpdateException>
	{
		public DbUpdateExceptionConverter(IServiceProvider services)
			: base(services, typeof(IExceptionErrorConverter<PostgresException>))
		{
		}

		public IErrorConvertationResult Convert(DbUpdateException exception)
		{
			Exception baseException = exception.GetBaseException();
			IErrorConvertationResult? result = AutoConvert(baseException);

			if (result != null)
				return result;

			return Single("Internal error of data updating");
		}
	}
}
