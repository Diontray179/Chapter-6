using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenperaureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int avj;
            int total = 0;
            int[] temps = new int[7];
            for (int i = 0; i < temps.Length; ++i) 
            {
                Console.WriteLine("Enter a temp");
                temps[i] = Convert.ToInt32(Console.ReadLine());
                total = temps[i] + total;
                count++;
               
            }
            avj = total / count;
            Console.WriteLine("----------------------------------");
            Console.WriteLine(avj);
        }
        
    }
}
