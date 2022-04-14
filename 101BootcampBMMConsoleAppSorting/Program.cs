using System;
using System.Collections.Generic;
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
            Sort s = new Sort();

            List<int> unSorted = s.GenerateIntList(10, 1, 10);

            Console.WriteLine("unsorted");
            foreach (int i in unSorted) 
            { 
                Console.WriteLine(i);                
            }

            DateTime timeStampStart = DateTime.Now;           
            List<int> _sorted =  s.Sorting(unSorted); // how long it this going to take

            Console.WriteLine("sorted");
            foreach (int item in _sorted)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("unsorted mergesort");
            int[] arr = new int[] { 200, 3, 66544, 23, 23, 34, 345345, 354, 3, 565, 4, 5, 567, 34, 5 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("sorted mergesort");
            int[] arr2 = MergeSort.mergeSort(arr);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
