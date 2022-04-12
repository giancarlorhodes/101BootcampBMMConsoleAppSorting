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
        public void Sort_100_integers_descending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();

            // act
            _listUnsorted = _sort.GenerateIntList(100);
            List<int> _listSorted = _sort.Sorting(_listUnsorted);
            // List<int> _testing = new List<int> { 1, 2, 6, 7 };

            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back descending list  1, 123, 2345 ....
            bool IsUnorderedDescending = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0)
                {
                    if (_listSorted[i] > _listSorted[i - 1])
                    {
                        continue;
                    }
                    else 
                    {
                        IsUnorderedDescending = false;
                        break;
                    }
                }                
            }

            Assert.IsTrue(IsUnorderedDescending);
        }


        [TestMethod]
        public void Sort_1000_integers_ascending()
        {

            // arrange
            List<int> _listUnsorted = new List<int>();

            // act
            _listUnsorted = _sort.GenerateIntList(1000, 1, 100000);
            List<int> _listSorted = _sort.Sorting(_listUnsorted, AscendingOrDescending.Ascending);


            // assert
            Assert.AreEqual(_listSorted.Count, _listUnsorted.Count); // same number of elements

            // pass in a unsorted list of integers and get back descending list  1, 123, 2345 ....
            bool IsUnorderedDescending = true;
            for (int i = 0; i < _listSorted.Count; i++)
            {
                if (i > 0)
                {
                    if (_listSorted[i] < _listSorted[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        IsUnorderedDescending = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(IsUnorderedDescending);
        }

    }
}
