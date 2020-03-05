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

            string[,] cloths = new string[,] { { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" } };

            string[] genres = { "classic", "pop", "classic", "classic", "pop" };
            int[] plays = { 500, 600, 150, 800, 2500 };


            string[] phonebook = { "119", "97674223", "1195524421" };
            int[] heights = { 6, 9, 5, 7, 4 };
            int[] trucks = {7, 4, 5, 6};
            Console.WriteLine(Bridge.Instance.solution(2, 10, trucks));
            Console.ReadLine();
        }
    }
}
