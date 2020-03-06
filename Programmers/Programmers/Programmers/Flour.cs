using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Flour : Singleton<Flour>
    {
        public int solution(int stock, int[] dates, int[] supplies, int k)
        {
            int answer = 0;

            int day = stock;

            int index = 0;

            Queue<int> amounts = new Queue<int>();
            amounts.OrderByDescending(x=>x);
            while (day < k)
            {
                while (index < dates.Length && dates[index] <= day)
                {
                    amounts.Enqueue(supplies[index]);
                    index++;
                }
                amounts = new Queue<int>(amounts.OrderByDescending(x => x));

                day += amounts.Dequeue();
                answer++;
            }
            return answer;
        }
    }
}
