using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace IntegorSharedErrorHandlers
{
	public static class JsonElementExtensions
	{
		public static JsonProperty GetPropertyCaseInsensitive(this JsonElement jsonElement, string propertyName)
		{
			foreach (JsonProperty prop in jsonElement.EnumerateObject())
			{
				if (prop.Name.ToLower() == propertyName.ToLower())
					return prop;
			}

			throw new KeyNotFoundException();
		}
	}
}
