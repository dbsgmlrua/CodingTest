using System;

namespace Programmers
{
    class Competition : Singleton<Competition>
    {
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
