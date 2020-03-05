using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Scoville
    {
        private static Scoville m_instance;
        public static Scoville Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Scoville();
                }
                return m_instance;
            }
        }

        public int solution(int[] scoville, int K)
        {
            int answer = 0;
            Queue<int> qq = new Queue<int>();
            Array.Sort(scoville);
            for(int i =0; i< scoville.Length; i++)
            {
                qq.Enqueue(scoville[i]);
            }
            while (true)
            {
                if (qq.First() > K)
                    break;
                if (qq.Count < 2)
                    return -1;

                qq.Enqueue(qq.Dequeue() + (qq.Dequeue() * 2));
                qq = new Queue<int>(qq.OrderBy(x => x));
                answer++;
            }

            return answer;
        }
    }
}
