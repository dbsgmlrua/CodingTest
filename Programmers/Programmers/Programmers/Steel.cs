using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Steel
    {
        private static Steel m_instance;
        public static Steel Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Steel();
                }
                return m_instance;
            }
        }
        public int solution(string arrangement)
        {
            int answer = 0;
            Stack<char> stack = new Stack<char>();

            for(int i=0;i< arrangement.Length; i++)
            {
                if(arrangement[i] == '(')
                {
                    stack.Push(arrangement[i]);
                }
                else
                {
                    stack.Pop();
                    if(arrangement[i - 1] == '(')
                    {
                        answer += stack.Count;
                    }
                    else
                    {
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
}
