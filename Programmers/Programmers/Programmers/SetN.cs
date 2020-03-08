using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class SetN : Singleton<SetN>
    {
        public int answer;
        public int solution(int N, int number)
        {
            answer = 9;
            cal(N, number, 0, 0);
            if (answer > 8) answer = -1;
            return answer;
        }
        public void cal(int N, int number, int count, long result)
        {
            if (answer < count) return;
            if (result == number)
            {
                if (count < answer)
                    answer = count;
                return;
            }

            if (count == 8)
                return;
            else
            {
                int rest = 8 - count;
                for (int i = 1; i <= rest; i++)
                {
                    int tailmax = i / 2;
                    for (int j = 0; j <= tailmax; j++)
                    {
                        int head = 0;

                        for (int k = 1; k <= i - j; k++)
                        {
                            head = head * 10 + N;
                        }

                        int next = head;
                        int tail = 0;
                        for (int k = 1; k <= j; k++)
                        {
                            tail = tail * 10 + N;
                        }
                        if (tail > 0) next /= tail;

                        cal(N, number, count + i, result + next);
                        cal(N, number, count + i, result - next);
                        cal(N, number, count + i, result * next);
                        cal(N, number, count + i, result / next);
                        cal(N, number, count + i, result * -1 * next);
                        cal(N, number, count + i, result * -1 / next);
                    }
                    if (i > 2)
                    {
                        cal(N, number, count + i, result);
                        cal(N, number, count + i, 0);
                    }
                }
            }
        }
    }
}
