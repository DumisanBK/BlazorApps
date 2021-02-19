using BancassuranceApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Utils
{
    public class JsonResultFacade : IJsonResultFacade
    {
        public JsonResult<bool> BooleanResult(bool data)
        {
            return SingleResult(data ? 0 : 1, data);
        }

        public JsonResult<T> GenericResult<T>(int errorCode, T data)
        {
            return new JsonResult<T>
            {
                ErrorCode = errorCode,
                Data = data
            };
        }

        public JsonResult<T> SingleResult<T>(T data)
        {
            int errorCode = data == null ? 1 : 0;

            return SingleResult(errorCode, data);
        }

        public JsonResult<T> SingleResult<T>(int errorCode, T data)
        {
            return GenericResult(errorCode, data);
        }

        public JsonResult<List<T>> ListResult<T>(List<T> data)
        {
            int errorCode = data.Count > 0 ? 0 : 1;

            return ListResult(errorCode, data);
        }

        public JsonResult<List<T>> ListResult<T>(int errorCode, List<T> data)
        {
            return GenericResult(errorCode, data);
        }

        public JsonResult<string> FormNotValidResult(int errorCode = 5, string data = "form not valid")
        {
            return GenericResult(errorCode, data);
        }
    }
}
