using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Airports : Singleton<Airports>
    {
        bool[] visit;
        public string[] solution(string[,] tickets)
        {
            List<string> answer = new List<string>();

            List<Airport> tmp = new List<Airport>();
            for(int i=0;i<tickets.GetLength(0);i++)
            {
                tmp.Add(new Airport(tickets[i, 0], tickets[i, 1]));
            }
            tmp = new List<Airport>(tmp.OrderBy(x => x.dep).ThenBy(b => b.des));

            for (int i = 0; i < tmp.Count; i++)
            {
                tickets[i, 0] = tmp[i].dep;
                tickets[i, 1] = tmp[i].des;
            }

            visit = new bool[tickets.Length];

            Visit.Enqueue("ICN");
            Dfs("ICN", tickets, 0);

            return Visit.ToArray();
        }
        class Airport
        {
            public string dep;
            public string des;
            public Airport(string p, string s)
            {
                dep = p;
                des = s;
            }
        }
        Queue<string> Visit = new Queue<string>();
        bool Dfs(string dep, string[,] tickets, int count)
        {
            if (count == tickets.GetLength(0))
            {
                return true;
            }

            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                if(tickets[i,0].Equals(dep))
                    if (!visit[i])
                    {
                        visit[i] = true;
                        Visit.Enqueue(tickets[i, 1]);
                        bool success = Dfs(tickets[i, 1], tickets, count + 1);
                        if (success)
                            return true;
                        visit[i] = false;
                    }
            }
            Visit.Dequeue();
            return false;
        }
    }
}
