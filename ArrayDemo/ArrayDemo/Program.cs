using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany;
            Console.WriteLine("How many numbers are you going to enter?");
            howMany = Convert.ToInt32(Console.ReadLine());
            int[] eightNums = new int[howMany];
            int entry;

            for (int i = 0; i < eightNums.Length; ++i)
            {
                Console.WriteLine("please enter a number >>>>>");
                eightNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("How do you want to see the information\n" +
                "1) first to last\n" +
                "2) last to first\n" +
                "choose a specific position");
            entry = Convert.ToInt32(Console.ReadLine());
    

        }
        
    }
    
}
