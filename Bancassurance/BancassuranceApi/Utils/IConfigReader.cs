using System.Collections.Generic;

namespace BancassuranceApi.Utils
{
    public interface IConfigReader
    {
        string Read(string key);
        List<string> Read(string UpperKey, string LowerKey);
    }
}