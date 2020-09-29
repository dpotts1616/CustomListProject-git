using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;


namespace CustomListTesting
{
    [TestClass]
    public class AddTests
    {
        //see correct count
        [TestMethod]
        public void Add_TwoValues_CountTwo()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_FiveValues_CountFive()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //capacity updates when list grows too large
        [TestMethod]
        public void Add_FiveValues_CapacityDoublesWhenListOutgrowsInitial()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 8;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            actual = list.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //added item is at end of current list
        [TestMethod]
        public void Add_FiveValues_NewItemIsAtEndOfList()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            actual = list[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //values are added to new list in correct order
        [TestMethod]
        public void Add_FiveValues_ItemsPopulateNewArrayInCorrectOrder()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected1 = 1;
            int expected3 = 3;
            int expected5 = 5;
            int actual1;
            int actual3;
            int actual5;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            actual1 = list[0];
            actual3 = list[2];
            actual5 = list[4];

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected5, actual5);
        }

        [TestMethod]
            [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Add_NoValues_CheckForIndexOutOfRange()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();

            //act
            int i = list[1];

            //assert
        }

        [TestMethod]
            [ExpectedException(typeof(NullReferenceException))]
        public void Add_NoValues_CheckForNullException()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();

            //act
            int i = list[0];

            //assert
        }
    }
}
