using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class BigNum : Singleton<BigNum>
    {
        public string solution(int[] numbers)
        {
            Array.Sort(numbers, (a, b) =>
            {
                return (b.ToString() + a.ToString()).CompareTo(a.ToString() + b.ToString());
            });
            if (numbers.Where(x => x == 0).Count() == numbers.Length)
                return "0";
            else
                return string.Join("", numbers);
        }
    }
}
