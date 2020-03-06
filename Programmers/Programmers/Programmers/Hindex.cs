using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Hindex
    {
        private static Hindex m_instance;
        public static Hindex Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Hindex();
                }
                return m_instance;
            }
        }

        public int solution(int[] citations)
        {
            int answer = 0;
            Array.Sort(citations, (a, b) => 
            {
                return b.CompareTo(a);
            });
             
            for(int i=0;i< citations.Length; i++)
            {
                if (i >= citations[i])
                {
                    break;
                }
                answer++;
            }

            return answer;
        }
    }
}
