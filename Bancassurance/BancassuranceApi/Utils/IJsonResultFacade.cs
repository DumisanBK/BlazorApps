using BancassuranceApi.ViewModels;
using System.Collections.Generic;

namespace BancassuranceApi.Utils
{
    public interface IJsonResultFacade
    {
        JsonResult<bool> BooleanResult(bool data);
        JsonResult<T> GenericResult<T>(int errorCode, T data);
        JsonResult<List<T>> ListResult<T>(int errorCode, List<T> data);
        JsonResult<List<T>> ListResult<T>(List<T> data);
        JsonResult<T> SingleResult<T>(int errorCode, T data);
        JsonResult<T> SingleResult<T>(T data);        
        JsonResult<string> FormNotValidResult(int errorCode = 5, string data = "form not valid");
    }
}