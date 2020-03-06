using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class DiskController
    {
        private static DiskController m_instance;
        public static DiskController Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new DiskController();
                }
                return m_instance;
            }
        }

        public int solution(int[,] jobs)
        {
            int answer = 0;
            int time = 0;

            List<DiskJobs> list = new List<DiskJobs>();
            for (int i = 0; i < jobs.GetLength(0); i++)
            {
                list.Add(new DiskJobs(jobs[i, 0], jobs[i, 1]));
            }
            list = new List<DiskJobs>(list.OrderBy(x => x.WorkTime));

            while (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (time >= list[i].StartTime)
                    {
                        time += list[i].WorkTime;
                        answer += time - list[i].StartTime;
                        list.RemoveAt(i);
                        break;
                    }
                    if (i == list.Count - 1)
                    {
                        time++;
                    }
                }
            }

            return answer / jobs.GetLength(0);
        }
        public class DiskJobs
        {
            public int StartTime;
            public int WorkTime;

            public DiskJobs(int s, int w)
            {
                StartTime = s;
                WorkTime = w;
            }
        }
    }
}
