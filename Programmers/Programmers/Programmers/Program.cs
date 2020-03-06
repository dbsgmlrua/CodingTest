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

            int[] progress = { 40, 93, 30, 55, 60, 65 };
            int[] speeds = { 60, 1, 30, 5, 10, 7 };

            int[] priorities = {1, 1, 9, 1, 1, 1};
            int locations = 0;

            string arrangement = "()(((()())(())()))(())";

            int[] prices = { 1, 2, 3, 2, 3 };

            int[] scoville = { 1, 2, 3, 9, 10, 12 };


            int[] dates = { 4, 10, 15 };
            int[] supplies = { 20, 5, 10 };

            int[,] jobs = { { 0, 3 }, { 1, 9 }, { 2, 6 } };


            string[] operations = { "I -45", "I 653", "D 1", "I -642", "I 45", "I 97", "D 1", "D -1", "I 333" };

            int[] arrays = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            
            int[] Numbers = { 3, 30, 34, 5, 9 };
            int[] citations = { 3, 0, 6, 1, 5 };

            Console.WriteLine(Hindex.Instance.solution(citations));
            Console.ReadLine();
        }
    }
}
