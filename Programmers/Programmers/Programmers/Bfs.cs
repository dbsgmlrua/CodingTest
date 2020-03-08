using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Bfs : Singleton<Bfs>
    {
        public int solution(int n, int[,] edge)
        {
            int answer = 0;

            Dictionary<int, List<int>> dicEdges = new Dictionary<int, List<int>>();

            for (int i = 0; i < edge.GetLength(0); i++)
            {
                if (!dicEdges.ContainsKey(edge[i, 0]))
                {
                    List<int> listEdges = new List<int> { };
                    listEdges.Add(edge[i, 1]);
                    dicEdges.Add(edge[i, 0], listEdges);
                }
                else
                {
                    dicEdges[edge[i, 0]].Add(edge[i, 1]);
                }
                if (!dicEdges.ContainsKey(edge[i, 1]))
                {
                    List<int> listEdges = new List<int> { };
                    listEdges.Add(edge[i, 0]);
                    dicEdges.Add(edge[i, 1], listEdges);
                }
                else
                {
                    dicEdges[edge[i, 1]].Add(edge[i, 0]);
                }
            }

            bool[] record = Enumerable.Repeat(false, n + 1).ToArray();
            int totalCount = 0;
            Queue<int> BFSQueue = new Queue<int>();
            int curEdgeLength = 0;

            record[1] = true;
            totalCount++;
            BFSQueue.Enqueue(1);
            while (totalCount != n)
            {
                curEdgeLength++;
                int curCount = 0;
                Queue<int> newBFSQueue = new Queue<int>();
                while (BFSQueue.Count != 0)
                {
                    foreach (int num in dicEdges[BFSQueue.Dequeue()])
                    {
                        if (!record[num])
                        {
                            record[num] = true;
                            newBFSQueue.Enqueue(num);
                            totalCount++;
                            curCount++;
                        }
                    }
                }

                BFSQueue = newBFSQueue;
                answer = curCount;
            }

            return answer;
        }
    }
}
