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

        List<int> Sorting(List<int> unsortList);

        List<int> Sorting(List<int> unsorList, AscendingOrDescending ds);

    }
}
