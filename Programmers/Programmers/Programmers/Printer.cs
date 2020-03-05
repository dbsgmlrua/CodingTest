using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programmers
{
    class Printer
    {
        private static Printer m_instance;
        public static Printer Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Printer();
                }
                return m_instance;
            }
        }
        public int solution(int[] priorities, int location)
        {
            int answer = 0;
            Queue<Print> Prints = new Queue<Print>();
            Print curr = null;
            for (int i = 0; i < priorities.Length; i++)
            {
                Prints.Enqueue(new Print(priorities[i], i));
            }
            while (Prints.Count > 0)
            {
                answer++;
                bool Check = true;
                int priority = Prints.Max(x=>x.priority);
                while(Check)
                {
                    Check = !(Prints.First().priority == priority);
                    if(Check)
                    {
                        curr = Prints.Dequeue();
                        Prints.Enqueue(curr);
                    }
                }
                if(Prints.First().index == location)
                    return answer;

                Prints.Dequeue();
            }
            return answer;
        }
        public class Print
        {
            public int priority;
            public int index;
            public Print(int p, int i)
            {
                priority = p;
                index = i;
            }
        }
    }
}
