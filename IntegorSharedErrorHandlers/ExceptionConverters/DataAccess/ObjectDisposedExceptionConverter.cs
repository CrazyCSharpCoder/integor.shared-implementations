using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorErrorsHandling;
using IntegorErrorsHandling.Converters;
using IntegorErrorsHandling.ExceptionsHandling;

using Npgsql;

namespace IntegorSharedErrorHandlers.ExceptionConverters.DataAccess
{
	public class ObjectDisposedExceptionConverter : LazyInjectableExceptionConverter, IExceptionErrorConverter<ObjectDisposedException>
	{
		public ObjectDisposedExceptionConverter(IServiceProvider services)
			: base(services, typeof(IExceptionErrorConverter<PostgresException>))
		{
		}

		public IErrorConvertationResult? Convert(ObjectDisposedException exception)
		{
			PostgresException? pgException = exception.GetBaseException() as PostgresException;

			if (pgException != null)
				return AutoConvert(pgException);

			return null;
		}
	}
}
