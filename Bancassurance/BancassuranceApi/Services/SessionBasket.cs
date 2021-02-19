using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public sealed class SessionBasket : ISessionBasket
    {
        private readonly IDictionary<string, object> _sessionValues;

        public SessionBasket()
        {
            _sessionValues = new Dictionary<string, object>();
        }

        public void Put(string key, object value)
        {
            _sessionValues.Add(key, value);
        }

        public object Pick(string key)
        {
            return _sessionValues[key];
        }

        public List<string> PickAllKeys()
        {
            var keys = _sessionValues.Keys.ToList();

            return keys;
        }

        public List<object> PickAllValues()
        {
            var values = _sessionValues.Values.ToList();

            return values;
        }

        public void Dispose()
        {
            _sessionValues.Clear();
        }

        public void Remove(string key)
        {
            try
            {
                _sessionValues.Remove(key);
            }
            catch (Exception)
            {
            }
        }
    }
}
