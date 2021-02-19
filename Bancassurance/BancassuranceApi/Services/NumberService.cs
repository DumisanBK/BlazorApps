using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class NumberService : INumberService
    {
        public int[] Generate(int start, int count)
        {
            int[] numbers = Enumerable.Range(start, count).ToArray();

            return numbers;
        }
    }
}
