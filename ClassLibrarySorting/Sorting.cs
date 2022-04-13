using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySorting
{


    public class Sorting : ISortable
    {

        public List<int> ListOfIntegers { get; set; }
        const int rangeMax = 100;
        const int numberElements = 100;

        public Sorting()
        {
            ListOfIntegers = new List<int>();
            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);

            for (int i = 0; i < numberElements; i++)
            {
                ListOfIntegers.Add(rnd.Next(0, rangeMax));
            }
        }


        public Sorting(int inNumberOfElements, int inRangeMax)
        {
            ListOfIntegers = new List<int>();
            int seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(seed);

            for (int i = 0; i < inNumberOfElements; i++)
            {
                ListOfIntegers.Add(rnd.Next(0, inRangeMax));
            }
        }

        public void BubbleSort() { }

        List<int> ISortable.Sorting(List<int> unsortList)
        {
            // throw new NotImplementedException();
            return new List<int>() { 0, 1, 2 }; // very poor implementation, does it meet the contract? Yes. 
        }



        public void BubbleSort()
        {
            // Bubble Sort is one of the simpler sorting algorithms that works by 
            // repeatedly swapping the adjacent elements if they are in wrong order.
            // 12, 5, 7, 10, 1, 160 arranged in ascending order are 1, 5, 7, 10, 12, 160. descending 
            // it opposite.

            // step 1 compare 1st and 2nd element, if 1st in greater then 2nd, flip their positions

            // step 2 continue down the array position, comparing 2nd and 3rd. ...

            // step 3 continue this process until you got thru the loop entirely without
            // ever flipping elements

            // step 4 if no flip occurred, you're done and sorted

            int IsFlipped = 0;
            while (IsFlipped >= 0)
            {
                // inner loop
                bool IsNotThruArray = true;
                int currentLocation = 0;
                int arrayLength = this.ListOfIntegers.Count;
                IsFlipped = -1;
                while (IsNotThruArray) // this loop will be used to go thru the array entirely
                                       // one time pass.
                {
                    // you are thru the entire array when you reach the last position
                    if (currentLocation == arrayLength - 1)
                    {
                        IsNotThruArray = false;    // reached the end, out of bounds for currentLocation                
                    }
                    else
                    {
                        // compare here
                        // TODO: need out of bounds check here
                        if (ListOfIntegers[currentLocation] > ListOfIntegers[currentLocation + 1])
                        {
                            // flip them
                            int holdit = ListOfIntegers[currentLocation + 1];
                            ListOfIntegers[currentLocation + 1] = ListOfIntegers[currentLocation];
                            ListOfIntegers[currentLocation] = holdit;
                            IsFlipped = IsFlipped + 1;
                        }
                        currentLocation = currentLocation + 1;
                    }
                }
                // IsNotThruArray = true;               
            }
        }
    }



}
