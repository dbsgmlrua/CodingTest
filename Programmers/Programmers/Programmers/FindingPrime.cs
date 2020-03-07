using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers
{
    class FindingPrime : Singleton<FindingPrime>
    {

        List<string> lstNums = new List<string>();
        List<long> lstNums2 = new List<long>();

        public bool IsPrime(long candidate) // 소수 판정
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        public int solution(string numbers)
        {
            int answer = 0;
            Perm(numbers.ToArray(), 0);
            lstNums = lstNums.Distinct().ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                foreach (long lNum in lstNums.Select(x => long.Parse(x.Substring(i))))
                {
                    lstNums2.Add(lNum);
                }
            }
            lstNums2 = lstNums2.Distinct().ToList();
            foreach (long lNum in lstNums2)
            {
                //Console.WriteLine(lNum.ToString());
                if (IsPrime(lNum)) answer++;
            }
            return answer;
        }
        public void Perm(char[] a, int k)   // 순열하기
        {
            if (k == a.Length - 1)//순열을 출력
            {
                lstNums.Add(new string(a));
            }
            else
            {
                for (int i = k; i < a.Length; i++)
                {
                    //a[k]와 a[i]를 교환
                    char temp = a[k];
                    a[k] = a[i];
                    a[i] = temp;

                    Perm(a, k + 1); //a[k+1],…,a[n-1]에 대한 모든 순열
                                    //원래 상태로 되돌리기 위해 a[k]와 a[i]를 다시 교환
                    temp = a[k];
                    a[k] = a[i];
                    a[i] = temp;
                }
            }
        }
    }
}
