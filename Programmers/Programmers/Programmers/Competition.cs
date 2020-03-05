using System;

namespace Programmers
{
    public class Competition
    {
        private static Competition m_instance;
        public static Competition Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Competition();
                }
                return m_instance;
            }
        }
        public string solution(string[] participant, string[] completion)
        {
            string answer = "";

            Array.Sort(participant);
            Array.Sort(completion);
            int i;
            for (i = 0; i < completion.Length; i++)
            {
                if (!participant[i].Equals(completion[i]))
                    return participant[i];
            }
            return participant[i];
        }
    }
}
