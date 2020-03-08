using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Joysticks : Singleton<Joysticks>
    {
        public int solution(string name)
        {
            int answer = 0;
            name.ToUpper();
            int[] NameNotA = new int[name.Length];

            for (int i = 0; i < name.Length; i++)
            {
                if (!name[i].Equals('A'))
                {
                    int asciicode = name[i] - 65;
                    int supfrom26 = Math.Abs(26 - asciicode);

                    answer += Math.Min(asciicode, supfrom26);
                    NameNotA[i] = Math.Min(asciicode, supfrom26);
                }
            }

            int currentIndex = 0;
            while (true)
            {
                NameNotA[currentIndex] = 0;
                if (End(NameNotA))
                    return answer;

                int left = 0;
                int right = 0;
                int leftindex = currentIndex;
                int rightindex = currentIndex;

                while (NameNotA[leftindex] == 0)
                {
                    leftindex--;
                    left++;
                    if (leftindex < 0)
                        leftindex = NameNotA.Length - 1;
                }
                while (NameNotA[rightindex] == 0)
                {
                    rightindex++;
                    right++;
                    if (rightindex >= NameNotA.Length)
                        rightindex = 0;
                }
                answer += (left < right) ? left : right;
                currentIndex = (left < right) ? leftindex : rightindex;
            }
        }
        bool End(int[] namenota)
        {
            for (int i = 0; i < namenota.Length; i++)
                if (namenota[i] != 0)
                    return false;
            return true;
        }
    }
}
