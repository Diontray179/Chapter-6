using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testScores
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = new int[8];
            int input;


            for (int i = 0; i <scores.Length; ++i)
            {
                 Console.WriteLine("please enter an test score #", + (i + 1));
                input = Convert.ToInt32(Console.ReadLine());
                scores[i] = input;
            
            }
            RunLine();
            DisplayScores(scores);

        }
        public static void DisplayTotal(int[] scores)
        {
            int total = 0;
            for (int i = 0; i < scores.Length; ++i)
            {
                total = total + scores[i];
            }
            RunLine();
            Console.WriteLine(total);
        }
        public static void DisplayScores(int[] scores)
        {
            Console.WriteLine("scores in original order");
            for (int i = 0; i < scores.Length; ++i) rr
            {
                Console.WriteLine("{0, 6}", scores[i]);
            }
            DisplayTotal(scores);
        }
        public static void RunLine()
        {
            Console.WriteLine("\n------------------------------------------------------------------");
        }
    }
}
