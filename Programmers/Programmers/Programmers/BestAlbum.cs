using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class BestAlbum
    {
        private static BestAlbum m_instance;
        public static BestAlbum Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new BestAlbum();
                }
                return m_instance;
            }
        }
        public int[] solution(string[] genres, int[] plays)
        {
            int[] answer = new int[] { };
            List<Music> musicList = new List<Music>();
            List<int> rank = new List<int>();

            for (int i = 0; i < genres.Length; i++)
            {
                Music music = new Music(i, genres[i], plays[i]);
                musicList.Add(music);
            }

            var musicGroupList = from m in musicList.OrderByDescending(s => s.play).ThenBy(s => s.seq)
                                 group m by m.genre into g
                                 orderby g.Sum(s => s.play) descending
                                 select g;

            foreach (var musicGroup in musicGroupList)
            {
                foreach (var item in musicGroup.Take(2))
                {
                    rank.Add(item.seq);
                }
            }

            answer = rank.ToArray();

            return answer;
        }
        private class Music
        {
            public int seq { get; set; }
            public string genre { get; set; }
            public int play { get; set; }

            public Music(int s, string g, int p)
            {
                seq = s;
                genre = g;
                play = p;
            }
        }
    }
}
