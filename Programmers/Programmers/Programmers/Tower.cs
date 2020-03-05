using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Programmers
{
    class Tower
    {
        private static Tower m_instance;
        public static Tower Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Tower();
                }
                return m_instance;
            }
        }
        public int[] solution(int[] heights)
        {
            int[] answer = new int[heights.Length];
            
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j= i - 1; j >= 0; j--)
                {
                    if (heights[j] > heights[i])
                    {
                        answer[i] = j + 1;
                        break;
                    }
                }
            }
            return answer;
        }
        //public int GetTower(int[] heights, int index)
        //{
        //    int i = index;
        //    int j;
        //    for (j = index - 1; j > 0; j--)
        //    {
        //        if(heights[j] > heights[i])
        //        {
        //            return j + 1;
        //        }
        //    }
        //    return j;
        //}
    }
}
