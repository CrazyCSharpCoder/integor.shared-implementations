using System;
using System.Linq;

using IntegorResponseDecoration;

namespace IntegorSharedResponseDecorators.Attributes
{
	using Decorators;

	public class DecorateErrorResponseAttribute : ResponseBodyDecorationFilterFactory
	{
		public DecorateErrorResponseAttribute()
			: base(typeof(ErrorResponseBodyDecorator))
		{
		}
	}
}
