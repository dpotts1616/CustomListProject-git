using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void ZipMethod_TwoIntLists_ListOneContainingAllContents()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int expected = 6;

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            list1.Zip(list2);

            //assert
            Assert.AreEqual(expected, list1.Count);
        }


        [TestMethod]
        public void ZipMethod_TwoIntLists_ListOneWithCorrectOrder()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string expected = "123456";

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            list1.Zip(list2);
            string listOne = list1.ToString();

            //assert
            Assert.AreEqual(expected, listOne);
        }

        [TestMethod]
        public void ZipMethod_TwoIntListsListOneLarger_ListOneWithCorrectOrder()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string expected = "123456";

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list1.Add(value6);
            list2.Add(value2);
            list2.Add(value4);
            list1.Zip(list2);
            string listOne = list1.ToString();

            //assert
            Assert.AreEqual(expected, listOne);
        }

        [TestMethod]
        public void ZipMethod_TwoIntListsListOneSmaller_ListOneWithCorrectOrder()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string expected = "123456";

            //act
            list1.Add(value1);
            list1.Add(value3);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            list1.Zip(list2);
            string listOne = list1.ToString();

            //assert
            Assert.AreEqual(expected, listOne);
        }


        [TestMethod]
        public void ZipMethod_TwoIntLists_ListTwoUnchanged()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            string expected = "246";

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            list1.Zip(list2);
            string listTwo = list2.ToString();

            //assert
            Assert.AreEqual(expected, listTwo);
        }
    }
}
