using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Jersey : Singleton<Jersey>
    {
        public int solution(int n, int[] lost, int[] reserve)
        {

            List<int> LostList = new List<int>();
            List<int> ReserveList = new List<int>();
            List<int> ReservedList = new List<int>();

            for (int i = 0; i < lost.Length; i++)
            {
                if (!reserve.Contains(lost[i]))
                    LostList.Add(lost[i]);
            }
            n -= LostList.Count;
            for (int i = 0; i < reserve.Length; i++)
            {
                if (!lost.Contains(reserve[i]))
                    ReserveList.Add(reserve[i]);
            }
            for (int i=0;i< ReserveList.Count; i++)
            {
                if(LostList.Contains(ReserveList[i] - 1))
                {
                    if (!ReserveList.Contains(ReserveList[i] - 1))
                    {
                        if (!ReservedList.Contains(ReserveList[i] - 1))
                        {
                            ReservedList.Add(ReserveList[i] - 1);
                            continue;
                        }
                    }
                }
                else if(LostList.Contains(ReserveList[i] + 1))
                {
                    if (!ReserveList.Contains(ReserveList[i] + 1))
                    {
                        if (!ReservedList.Contains(ReserveList[i] + 1))
                        {
                            ReservedList.Add(ReserveList[i] + 1);
                            continue;
                        }
                    }
                }
            }
            return n + ReservedList.Count;
        }
    }
}
