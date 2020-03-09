using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class NetworkDfs : Singleton<NetworkDfs>
    {
        public bool[,] Links;
        public int solution(int n, int[,] computers)
        {
            int answer = 0;
            Links = new bool[n, n];
            for(int i = 0; i < n; i++)
            {
                if (!Links[i, i])
                {
                    Dfs(n, computers, i);
                    answer++;
                }
            }

            return answer;
        }
        public void Dfs(int n, int[,] computers, int index)
        {
            for (int i = 0; i < n; i++)
            {
                if(computers[index,i] == 1 && !Links[index, i])
                {
                    Links[index, i] = Links[i,index] = true;
                    Dfs(n, computers, i);
                }
            }
        }
    }
}
