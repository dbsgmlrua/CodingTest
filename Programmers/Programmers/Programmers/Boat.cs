using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Boat : Singleton<Boat>
    {
        public int solution(int[] people, int limit)
        {
            int answer = 0;
            Array.Sort(people);
            int i = 0;
            int j = 0;

            for(i = people.Length - 1; i > j; i--)
            {
                if(people[j] + people[i] <= limit)
                {
                    j++;
                    answer++;
                }
                else
                {
                    answer++;
                }
            }
            if (i == j)
                answer++;

            return answer;
        }
    }
}
