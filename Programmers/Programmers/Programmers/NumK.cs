using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class NumK
    {
        private static NumK m_instance;
        public static NumK Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new NumK();
                }
                return m_instance;
            }
        }
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            for(int i = 0; i < commands.GetLength(0); i++)
            {
                int start = commands[i, 0] - 1;
                int end = commands[i, 1];
                int pos = commands[i, 2] - 1;

                List<int> list = new List<int>();
                for(int j= start;j< end; j++)
                {
                    list.Add(array[j]);
                }
                list = new List<int>(list.OrderBy(x => x));
                if (list.Count > pos)
                    answer[i] = list[pos];
            }
            return answer;
        }
    }
}
