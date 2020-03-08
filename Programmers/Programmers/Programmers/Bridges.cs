using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Bridges : Singleton<Bridges>
    {
        public int solution(int n, int[,] costs)
        {
            int answer = 0;
            List<Bridge> bridges = new List<Bridge>();
            for (int i = 0; i < costs.GetLength(0); i++)
            {
                Bridge b = new Bridge(costs[i, 1], costs[i, 0], costs[i, 2]);
                bridges.Add(b);
            }

            List<int> viaCities = new List<int>();
            viaCities.Add(0);

            do
            {
                bool check = false;
                int minCosts = int.MaxValue;
                Bridge nextBridge = new Bridge();
                foreach (Bridge b in bridges)
                {
                    if (viaCities.Contains(b.startNode) && !viaCities.Contains(b.endNode))
                    {
                        if (b.cost < minCosts)
                        {
                            nextBridge = b;
                            minCosts = b.cost;
                            check = false;
                        }
                    }
                    if (viaCities.Contains(b.endNode) && !viaCities.Contains(b.startNode))
                    {
                        if (b.cost < minCosts)
                        {
                            nextBridge = b;
                            minCosts = b.cost;
                            check = true;
                        }
                    }
                }
                if (check)
                {
                    viaCities.Add(nextBridge.startNode);
                }
                else
                {
                    viaCities.Add(nextBridge.endNode);
                }
                answer += minCosts;
                bridges.Remove(nextBridge);

            } while (!(viaCities.Count == n));
            return answer;
        }

        class Bridge
        {
            public Bridge()
            {

            }

            public Bridge(int s, int e, int c)
            {
                this.startNode = s;
                this.endNode = e;
                this.cost = c;
            }

            public int startNode;
            public int endNode;
            public int cost;
        }
    }
}
