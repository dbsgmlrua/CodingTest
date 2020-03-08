using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class FindBigNum : Singleton<FindBigNum>
    {
        public string solution(string number, int k)
        {
            number = "9" + number;
            StringBuilder builder = new StringBuilder(number);
            int i = 0;
            for (int j = 0; j < k; j++)
            {
                while (true)
                {
                    if(i + 1 >= builder.Length)
                    {
                        builder.Remove(i, 1);
                        i--;
                        break;
                    }
                    if ((builder[i] - '0') < (builder[i + 1] - '0'))
                    {
                        builder.Remove(i, 1);
                        i--;
                        break;
                    }
                    i++;
                }
            }

            return builder.Remove(0,1).ToString();
        }
    }
}
