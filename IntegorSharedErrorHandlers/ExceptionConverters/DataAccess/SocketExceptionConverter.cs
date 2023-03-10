﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

using IntegorErrorsHandling;
using IntegorErrorsHandling.Converters;

namespace IntegorSharedErrorHandlers.ExceptionConverters.DataAccess
{
	using Internal;

	public class SocketExceptionConverter : ConverterBase, IExceptionErrorConverter<SocketException>
	{
		public IErrorConvertationResult? Convert(SocketException exception)
		{
			return Single(DatabaseErrorsConstants.InternalDatabaseErrorMessage);
		}
	}
}
