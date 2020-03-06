using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class PriorityQueue
    {
        private static PriorityQueue m_instance;
        public static PriorityQueue Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new PriorityQueue();
                }
                return m_instance;
            }
        }
        public int[] solution(string[] operations)
        {
            int[] answer = new int[2];

            string INSERTORDER = "I";
            string DELETEORDER = "D";

            List<int> Pq = new List<int>();

            for(int i=0;i< operations.Length; i++)
            {
                string[] words = operations[i].Split(' ');
                if (words[0].Equals(INSERTORDER))
                {
                    int value = 0;
                    int.TryParse(words[1], out value);

                    Pq.Add(value);
                }
                else if(words[0].Equals(DELETEORDER))
                {
                    if (Pq.Count > 0)
                    {
                        int value;
                        int.TryParse(words[1],out value);
                        if (value == 1)
                        {
                            Pq.Remove(Pq.Max());
                        }
                        else if(value == -1)
                        {
                            Pq.Remove(Pq.Min());
                        }
                    }
                }
            }

            if(Pq.Count > 0)
            {
                answer[1] = Pq.Min();
                answer[0] = Pq.Max();
            }

            return answer;
        }
    }
}
