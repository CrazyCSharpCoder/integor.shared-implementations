using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

using IntegorErrorsHandling;

namespace IntegorSharedErrorHandlers
{
    public class JsonError : IResponseError
    {
        public dynamic Error { get; }

        public JsonError(JsonElement root)
        {
            Error = root;
        }

        public object ToResponseObject()
        {
            return Error;
        }
    }
}
