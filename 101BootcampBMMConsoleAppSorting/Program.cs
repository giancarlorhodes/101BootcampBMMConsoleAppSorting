using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySorting;

namespace _101BootcampBMMConsoleAppSorting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting ....");
            Sorting s = new Sorting(10,100000); // this will create a million integers
            Console.WriteLine("Sorting object created.");

            Console.WriteLine("Before the sort");
            DateTime timeStampStart = DateTime.Now;
            //foreach (int item in s.ListOfIntegers)
            //{
            //    Console.WriteLine(item);
            //}

            s.BubbleSort(); // how long it this going to take

            DateTime timeStampStop = DateTime.Now;
            TimeSpan ts = timeStampStop - timeStampStart;
            Console.WriteLine("After the sort, time elapsed in seconds is: " + ts);
            int counter = 0;
            foreach (int item in s.ListOfIntegers)
            {
                Console.WriteLine(item);

                if (counter >= 10) break;
                counter = counter + 1;
            }

            Console.ReadLine();
        }
    }
}
