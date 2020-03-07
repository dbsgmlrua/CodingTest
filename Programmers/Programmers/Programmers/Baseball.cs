using System;
using System.Collections.Generic;
using System.Linq;
namespace Programmers
{
    class Baseball :Singleton<Baseball>
    { 
        public int solution(int[,] baseball)
        {
            List<string> allcase = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (i == j)
                        continue;

                    for (int k = 1; k <= 9; k++)
                    {
                        if (j == k || i == k)
                            continue;

                        allcase.Add((i.ToString() + j.ToString() + k.ToString()));
                    }
                }
            }
            int answer = 0;
            for (int i = 0; i < allcase.Count; i++)
            {
                bool find = true;
                for(int j = 0; j < baseball.GetLength(0); j++)
                {
                    string bb = baseball[j, 0].ToString();
                    int strike = 0;
                    int ball = 0;

                    for(int k = 0; k < bb.Length; k++)
                    {
                        if (allcase[i].Contains(bb[k]))
                        {
                            if (allcase[i][k] == bb[k])
                                strike++;
                            else
                                ball++;
                        }
                    }
                    if (strike == baseball[j, 1] && ball == baseball[j, 2])
                        continue;
                    else
                    {
                        find = false;
                        break;
                    }
                }
                if (find)
                    answer++;
            }
            return answer;
        }
    }
}
