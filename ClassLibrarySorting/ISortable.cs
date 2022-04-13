using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySorting
{
    // pass in unsorted list of number and get back a sort list ascending
    interface ISortable
    {

        // pass in a unsorted list of integers and get back descending list  1, 123, 2345 ....
        List<int> Sorting(List<int> unsortList);

         // pass in a unsorted list of integers and get back descending or ascending controlled by enum
        List<int> Sorting(List<int> unsortList, AscendingOrDescending ds);

        // pass in a length and integers will be Pseudorandom number generator
        List<int> GenerateIntList(int numberOfIntergersToGenerate);

        // pass in a length and integers will be Pseudorandom number generated and will be passed back
        List<int> GenerateIntList(int numberOfIntergersToGenerate, int minNum, int maxNum);



    }
}
