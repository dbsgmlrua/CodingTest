using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Programmers
{
    class MokTest : Singleton<MokTest>
    {
        public int[] solution(int[] answers)
        {
            List<int> answer = new List<int>();

            int[] ans1 = new int[] { 1, 2, 3, 4, 5 };
            int[] ans2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] ans3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int[] anscount = new int[3];
            for(int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == ans1[i % ans1.Length])
                    anscount[0]++;
                if (answers[i] == ans2[i % ans2.Length])
                    anscount[1]++;
                if (answers[i] == ans3[i % ans3.Length])
                    anscount[2]++;
            }
            int WinNum = anscount.Max();

            for(int i = 0; i < anscount.Length; i++)
            {
                if (anscount[i] == WinNum)
                    answer.Add(i + 1);
            }

            return answer.ToArray();
        }
    }
}
