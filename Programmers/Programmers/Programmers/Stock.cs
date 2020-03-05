using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Stock
    {
        private static Stock m_instance;
        public static Stock Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Stock();
                }
                return m_instance;
            }
        }
        public int[] solution(int[] prices)
        {
            List<int> answer = new List<int>();

            for(int i=0;i< prices.Length; i++)
            {
                int count = 0;
                for(int j=i + 1;j< prices.Length; j++)
                {
                    count++;
                    if (prices[i] > prices[j])
                        break;
                }
                answer.Add(count);
            }

            return answer.ToArray();
        }
    }
}
