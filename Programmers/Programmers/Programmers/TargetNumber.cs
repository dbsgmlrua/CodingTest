using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class TargetNumber :Singleton<TargetNumber>
    {
        int answer = 0;
        public int solution(int[] numbers, int target)
        {
            Dfs(numbers, target, 0, 0);
            return answer;
        }
        void Dfs(int[] numbers, int target, int sum, int index)
        {
            if (index >= numbers.Length)
            {
                if (sum == target)
                    answer++;
                return;
            }
            Dfs(numbers, target, sum + numbers[index], index + 1);
            Dfs(numbers, target, sum - numbers[index], index + 1);

        }
    }
}
