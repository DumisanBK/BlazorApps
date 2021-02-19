using System;
using System.Collections.Generic;

namespace BancassuranceApi.Services
{
    public interface ISessionBasket : IDisposable
    {
        object Pick(string key);
        List<string> PickAllKeys();
        List<object> PickAllValues();
        void Put(string key, object value);
        void Remove(string key);
    }
}