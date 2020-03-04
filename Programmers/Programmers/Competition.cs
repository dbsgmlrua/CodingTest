using System;

public class Competition
{
    private static Competition m_instance;
    public static Competition Instance
    {
        get
        {
            if(m_instance == null)
            {
                m_instance = new Competition();
            }
            return m_instance;
        }
    }
    public String solution(string[] participant, string[] completion)
    {
        String answer = "";
        
        Array.Sort(participant);
        Array.Sort(completion);
        int i;
        for (i = 0; i < completion.length; i++)
        {
            if (!participant[i].equals(completion[i]))
                return participant[i];
        }
        return answer;
    }
}
