using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Programmers
{
    class FunctionDev
    {
        private static FunctionDev m_instance;
        public static FunctionDev Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new FunctionDev();
                }
                return m_instance;
            }
        }
        public int[] solution(int[] progresses, int[] speeds)
        {
            MyJob[] jobb = new MyJob[progresses.Length];
            List<int> answer = new List<int>();
            int answerPointer = 0;
            for (int i=0;i< jobb.Length; i++)
            {
                jobb[i] = new MyJob(progresses[i], speeds[i]);
            }
            int time = 0;

            while(!JobDone(answer, jobb.Length))
            {
                time++;
                for (int i= answerPointer;i< jobb.Length; i++)
                {
                    jobb[i].AddSpeed();
                }
                if (jobb[answerPointer].JobDone())
                {
                    int count = 0;
                    while (jobb[answerPointer].JobDone())
                    {
                        count++;
                        answerPointer++;
                        if (answerPointer >= jobb.Length)
                            break;
                    }
                    answer.Add(count);
                }
                Thread.Sleep(100);
                Console.WriteLine(time + ":::::::" + answerPointer);
            }
            //int[] result = answer.ToArray();
            return answer.ToArray();
        }
        bool JobDone(List<int> answer, int target)
        {
            if (answer.Count <= 0)
                return false;
            int result = 0;
            for (int i = 0; i < answer.Count; i++)
            {
                result += answer[i];
            }
            return result >= target;
        }
        public class MyJob
        {
            public int progress;
            public int speed;
            public void AddSpeed()
            {
                progress += speed;
            }
            public bool JobDone()
            {
                return progress >= 100;
            }
            public MyJob(int p, int s)
            {
                progress = p;
                speed = s;
            }
        }
    }
}
