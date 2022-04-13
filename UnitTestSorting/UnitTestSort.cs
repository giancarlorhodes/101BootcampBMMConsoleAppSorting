using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrarySorting;
using System.Collections.Generic;

namespace UnitTestSorting
{
    [TestClass]
    public class UnitTestSort
    {
        private Sort _sort;

        public UnitTestSort() { _sort = new Sort();  }

        [TestMethod]
        public void Generate_100_integers()
        {
            // arrange
            List<int> _list = new List<int>();

            // act
            _list = _sort.GenerateIntList(100);

            // assert
            Assert.AreEqual(100, _list.Count);
        }


        [TestMethod]
        public void Generate_zero_integers()
        {
            // arrange
            List<int> _list = new List<int>();

            // act
            _list = _sort.GenerateIntList(0);

            // assert
            Assert.AreEqual(0, _list.Count);
        }

        [TestMethod]
        public void Generate_100_integers_between_1_and_10()
        {
            // arrange
            List<int> _list = new List<int>();

            // act
            _list = _sort.GenerateIntList(100, 1, 10);

            // assert
            Assert.AreEqual(100, _list.Count);

            foreach (int i in _list)
            {
                Assert.IsTrue(i >= 1 && i <= 10);
            }
        }


        [TestMethod]
        public void Sort_100_integers_ascending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();

            // act
            _listUnsorted = _sort.GenerateIntList(100);
            List<int> _listSorted = _sort.Sorting(_listUnsorted); // desc
            // List<int> _testing = new List<int> { 1, 2, 6, 7 };

            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back descending list  1, 123, 2345 ....
            bool IsUnordered = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0) // make sure we are in index range
                {
                    if (_listSorted[i] > _listSorted[i - 1] || _listSorted[i] == _listSorted[i - 1])
                    {
                        continue;
                    }
                    else 
                    {
                        IsUnordered = false;
                        break;
                    }
                }                
            }

            Assert.IsTrue(IsUnordered);
        }


        [TestMethod]
        public void Sort_100_integers_between_1_and_100000_ascending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();
            //_listUnsorted = new List<int> { 3, 21, 131 }; // ascending

            // act
            _listUnsorted = _sort.GenerateIntList(100, 1, 100000);

            List<int> _listSorted = _sort.Sorting(_listUnsorted, AscendingOrDescending.Ascending);


            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back ascending list 
            bool IsUnordered = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0)
                {
                    if (_listSorted[i] > _listSorted[i - 1] || _listSorted[i] == _listSorted[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        IsUnordered = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(IsUnordered);
        }


        [TestMethod]
        public void Sort_1000_integers_between_1_and_100_ascending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();
            //_listUnsorted = new List<int> { 3, 3, 2, 21, 100, 100, 21 }; // ascending

            // act
            _listUnsorted = _sort.GenerateIntList(1000, 1, 100);

            List<int> _listSorted = _sort.Sorting(_listUnsorted, AscendingOrDescending.Ascending);


            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back ascending list 
            bool IsUnordered = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0)
                {
                    if (_listSorted[i] > _listSorted[i - 1] || _listSorted[i] == _listSorted[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        IsUnordered = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(IsUnordered);
        }

        [TestMethod]
        public void Sort_1000_integers_between_neg100_and_pos100_descending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();
            //_listUnsorted = new List<int> { 3, 3, -3, -21, -100, -100 }; // descending

            // act
            _listUnsorted = _sort.GenerateIntList(1000, -100, 100);

            List<int> _listSorted = _sort.Sorting(_listUnsorted, AscendingOrDescending.Descending);

            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back ascending list 
            bool IsUnordered = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0)
                {
                    if (_listSorted[i] < _listSorted[i - 1] || _listSorted[i] == _listSorted[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        IsUnordered = false;
                        break;
                    }
                }
            }
            Assert.IsTrue(IsUnordered);
        }


        [TestMethod]
        public void Sort_1000_integers_between_neg1000_and_pos1000_descending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();
           
            // act
            _listUnsorted = _sort.GenerateIntList(1000, -1000, 1000);

            List<int> _listSorted = _sort.Sorting(_listUnsorted, AscendingOrDescending.Descending);

            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back ascending list 
            bool IsUnordered = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0)
                {
                    if (_listSorted[i] < _listSorted[i - 1] || _listSorted[i] == _listSorted[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        IsUnordered = false;
                        break;
                    }
                }
            }
            Assert.IsTrue(IsUnordered);
        }


    }
}
