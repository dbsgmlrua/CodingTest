using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Weight : Singleton<Weight>
    {
        public int solution(int[] weight)
        {
            int answer = 0;
            Array.Sort(weight);
            answer += weight[0];

            for(int i = 0; i < weight.Length; i++)
            {
                if (answer + 1 < weight[i])
                    break;
                else
                    answer += weight[i];
            }


            return answer;
        }
    }
}
