using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class ChangeWord : Singleton<ChangeWord>
    {
        public int solution(string begin, string target, string[] words)
        {
            int answer = 0;
            Dfs(begin, target, words, 0, begin);
            if(ans.Count > 0)
            {
                ans = new List<int>(ans.OrderBy(x => x));
                answer = ans[0];
            }
            return answer;
        }
        List<int> ans = new List<int>();
        public void Dfs(string begin, string target, string[] words, int index, string history)
        {
            for(int i = 0; i < words.Length; i++)
            {
                int sameCount = 0;
                string tmp = words[i];
                for(int j = 0; j < begin.Length; j++)
                {
                    if (begin[j] == tmp[j])
                        sameCount++;
                }
                if(sameCount == begin.Length - 1)
                {
                    if (!history.Contains(tmp))
                    {
                        if (tmp.Equals(target))
                        {
                            ans.Add(index + 1);
                            return;
                        }
                        Dfs(tmp, target, words, index + 1, history + " " + tmp);
                    }
                }
            }
        }
    }
}
