using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Spy
    {
        private static Spy m_instance;
        public static Spy Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Spy();
                }
                return m_instance;
            }
        }
        public int solution(string[,] clothes)
        {
            int answer = 1;

            Dictionary<string, int> hash = new Dictionary<string, int>();
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!hash.ContainsKey(clothes[i, 1]))
                {
                    hash.Add(clothes[i, 1], 1);
                }
                else
                {
                    hash[clothes[i, 1]] += 1;
                }
            }
            foreach (KeyValuePair<string, int> k in hash)
            {
                answer *= (k.Value + 1);
            }

            return answer - 1;
        }
    }
}
