using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] idNumber = { 122, 167, 204, 219, 345 };
            string[] names = { "tyna", "jordan", "jon", "isabella", "thomas", "Ethan" };
            int entryID;

            Console.WriteLine("enter an employee ID");
            entryID = Convert.ToInt32(Console.ReadLine());
            DisplayBinarySort(idNumber, entryID);
            DisplayNames(names);
        }
        public static void DisplayNames(string [] names)
        {
          
            Array.Sort(names);
            for (int x = 0; x < names.Length; ++x) 
            {
                Console.WriteLine(names[x]);
            }
            Array.Sort(names);
            for (int x = 0; x > names.Length; ++x)
            {
                Console.WriteLine(names[x]);
            }
        }
        public static void DisplayBinarySort(int[] idnumber, int entryID)
        {
            int x;
            x = Array.BinarySearch(idnumber, entryID);
            if (x < 0)
            {
                Console.WriteLine("ID {0} not found", entryID);
            }
            else
            {
                Console.WriteLine("ID {0 found at position{1}", entryID, x);
            }
        }
       

    }
}
