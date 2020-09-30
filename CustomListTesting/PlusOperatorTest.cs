using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class PlusOperatorTest
    {
        [TestMethod]
        public void PlusOperator_TwoIntLists_OneListWithListOneThenListTwo()
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

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            CustomList<int> result = list1 + list2;

            //assert
            Assert.AreEqual(value1, result[0]);
            Assert.AreEqual(value3, result[1]);
            Assert.AreEqual(value5, result[2]);
            Assert.AreEqual(value2, result[3]);
            Assert.AreEqual(value4, result[4]);
            Assert.AreEqual(value6, result[5]);
        }

        [TestMethod]
        public void PlusOperator_TwoIntLists_CountEqualsTotalOfBothLists()
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
            CustomList<int> result = list1 + list2;

            //assert
            Assert.AreEqual(expected, result.Count);
        }

        [TestMethod]
        public void PlusOperator_OneEmptyIntLists_ResultEqualsListOne()
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

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list1.Add(value2);
            list1.Add(value4);
            list1.Add(value6);
            CustomList<int> result = list1 + list2;

            //assert
            Assert.AreEqual(value1, result[0]);
            Assert.AreEqual(value3, result[1]);
            Assert.AreEqual(value5, result[2]);
            Assert.AreEqual(value2, result[3]);
            Assert.AreEqual(value4, result[4]);
            Assert.AreEqual(value6, result[5]);
        }

        [TestMethod]
        public void PlusOperator_TwoStringLists_OneListWithListOneThenListTwo()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            string value1 = "Dylan";
            string value2 = "Nevin";
            string value3 = "David";
            string value4 = "Charles";

            //act
            list1.Add(value1);
            list1.Add(value2);
            list2.Add(value3);
            list2.Add(value4);
            CustomList<string> result = list1 + list2;

            //assert
            Assert.AreEqual(value1, result[0]);
            Assert.AreEqual(value2, result[1]);
            Assert.AreEqual(value3, result[2]);
            Assert.AreEqual(value4, result[3]);
        }


        [TestMethod]
        public void PlusOperator_TwoUnevenIntLists_FirstListLonger_ResultListWithAllValues()
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

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list1.Add(value2);
            list1.Add(value4);
            list2.Add(value6);
            CustomList<int> result = list1 + list2;

            //assert
            Assert.AreEqual(value1, result[0]);
            Assert.AreEqual(value3, result[1]);
            Assert.AreEqual(value5, result[2]);
            Assert.AreEqual(value2, result[3]);
            Assert.AreEqual(value4, result[4]);
            Assert.AreEqual(value6, result[5]);
        }

        [TestMethod]
        public void PlusOperator_TwoUnevenIntLists_FirstListShorter_ResultListWithAllValues()
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

            //act
            list1.Add(value1);
            list2.Add(value3);
            list2.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            CustomList<int> result = list1 + list2;

            //assert
            Assert.AreEqual(value1, result[0]);
            Assert.AreEqual(value3, result[1]);
            Assert.AreEqual(value5, result[2]);
            Assert.AreEqual(value2, result[3]);
            Assert.AreEqual(value4, result[4]);
            Assert.AreEqual(value6, result[5]);
        }

        [TestMethod]
        public void PlusOperator_ThreeIntLists_ResultListWithAllValues()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            //act
            list1.Add(value1);
            list1.Add(value3);
            list2.Add(value5);
            list2.Add(value2);
            list3.Add(value4);
            list3.Add(value6);
            CustomList<int> result = list1 + list2 + list3;

            //assert
            Assert.AreEqual(value1, result[0]);
            Assert.AreEqual(value3, result[1]);
            Assert.AreEqual(value5, result[2]);
            Assert.AreEqual(value2, result[3]);
            Assert.AreEqual(value4, result[4]);
            Assert.AreEqual(value6, result[5]);
        }
    }
}
