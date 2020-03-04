using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participant = { "leo", "kiki", "eden" };
            string[] completion = { "eden", "kiki" };

            Console.WriteLine(Competition.Instance.solution(participant, completion));
            Console.ReadLine();
        }
    }
}
