using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class TakeaLook : Singleton<TakeaLook>
    {
        public int[] solution(int brown, int red)
        {
            int[] answer = new int[2];

            int sum = brown + red;

            int sqrt = (int)Math.Sqrt(sum);

            for(int i = sqrt; i < sum; i++)
            {
                int j = sum / i;
                if((j - 2) * (i-2) == red)
                {
                    answer[0] = i;
                    answer[1] = j;

                    break;
                }
            }

            return answer;
        }
    }
}
