using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySorting
{

    public class Sort : ISortable
    {

        //public List<int> ListOfIntegers { get; set; }
        //const int rangeMax = 100;
        //const int numberElements = 100;

        // constructors
        //public Sort()
        //{
        //    ListOfIntegers = new List<int>();
        //    int seed = (int)DateTime.Now.Ticks;
        //    Random rnd = new Random(seed);

        //    for (int i = 0; i < numberElements; i++)
        //    {
        //        ListOfIntegers.Add(rnd.Next(0, rangeMax));
        //    }
        //}


        //public Sort(int inNumberOfElements, int inRangeMax)
        //{
        //    ListOfIntegers = new List<int>();
        //    int seed = (int)DateTime.Now.Ticks;
        //    Random rnd = new Random(seed);

        //    for (int i = 0; i < inNumberOfElements; i++)
        //    {
        //        ListOfIntegers.Add(rnd.Next(0, inRangeMax));
        //    }
        //}

        // methods implements ISortable
       

        public List<int> GenerateIntList(int numberOfIntergersToGenerate)
        {
            return Generate(numberOfIntergersToGenerate, int.MinValue, int.MaxValue);
        }

     
        public List<int> GenerateIntList(int numberOfIntergersToGenerate, int minNum, int maxNum) 
        {
            return Generate(numberOfIntergersToGenerate, minNum, maxNum);
        }


        private static List<int> Generate(int numberOfIntergersToGenerate, int min, int max)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<int> list = new List<int>();

            for (int i = 0; i < numberOfIntergersToGenerate; i++)
            {
                list.Add(rnd.Next(min, max));
            }
            return list;
        }

        public List<int> SortingOld(List<int> unsortedList)
        {
            //return unsortList; // // very poor implementation, does it meet the contract? Yes. 

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
            List<int> list = new List<int>();
            list = unsortedList; // starts unsorted

            while (IsFlipped >= 0)
            {
                // inner loop
                bool IsNotThruArray = true;
                int currentLocation = 0;
                int arrayLength = list.Count;
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
                        if (list[currentLocation] > list[currentLocation + 1])
                        {
                            // flip them
                            int holdit = list[currentLocation + 1];
                            list[currentLocation + 1] = list[currentLocation];
                            list[currentLocation] = holdit;
                            IsFlipped = IsFlipped + 1;
                        }
                        currentLocation = currentLocation + 1;
                    }
                }
            }

            return list;
        }

        public List<int> Sorting(List<int> unsortedList)
        {
            List<int> sortedList;
            sortedList = this.Sorting(unsortedList, AscendingOrDescending.Ascending);
            return sortedList;
        }


        public List<int> Sorting(List<int> unsortedList, AscendingOrDescending ds)
        {
            List<int> sortedList = unsortedList;

            //return unsortList; // // very poor implementation, does it meet the contract? Yes. 

            // Bubble Sort is one of the simpler sorting algorithms that works by 
            // repeatedly swapping the adjacent elements if they are in wrong order.
            // 12, 5, 7, 10, 1, 160 arranged in ascending order are 1, 5, 7, 10, 12, 160. descending 
            // it opposite.

                              

            if (sortedList == null || sortedList.Count <= 1)
            {
                return sortedList;
            }
            else
            {

                // ascending  1, 2, 100, 1233 .... 
                bool IsSwap = true;
                
                while (IsSwap) 
                {    
                    IsSwap = false;
                    for (int i = 0; i < sortedList.Count; i++)
                    {
                        if (i >= 1 ) 
                        {
                            if (ds == AscendingOrDescending.Descending)
                            {
                                // step 1 compare 1st and 2nd element, if 1st in greater then 2nd, flip their positions
                                if (sortedList[i] > sortedList[i - 1])
                                {
                                    int temp = sortedList[i - 1];
                                    sortedList[i - 1] = sortedList[i];
                                    sortedList[i] = temp;                                    
                                    IsSwap = true;
                                }
                                // step 2 continue down the array position, comparing 2nd and 3rd. ...
                            }
                            else // ascending is the default
                            {
                                // step 1 compare 1st and 2nd element, if 1st in greater then 2nd, flip their positions
                                if (sortedList[i] < sortedList[i - 1])
                                {
                                    int temp = sortedList[i];
                                    sortedList[i] = sortedList[i - 1];
                                    sortedList[i - 1] = temp;
                                    IsSwap = true;
                                }
                                // step 2 continue down the array position, comparing 2nd and 3rd. ...
                            }
                        }
                    }
                    // step 3 continue this process until you got thru the loop entirely without
                    // ever flipping elements

                    // step 4 if no flip occurred, you're done and sorted
                }
            }
            return sortedList;
        }


    }



}
