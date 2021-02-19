using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Utils
{
    public class StringExtensions : IStringExtensions
    {
        public string Trim(string textToTrim, int length = 14)
        {
            if (string.IsNullOrEmpty(textToTrim)) return textToTrim;

            if (textToTrim.Length <= length) return textToTrim;

            return textToTrim.Substring(0, length);
        }
    }
}
