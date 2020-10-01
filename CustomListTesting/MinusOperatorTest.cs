using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class MinusOperatorTest
    {
        [TestMethod]
        public void MinusOperator_TwoIntLists_ListOneMissingNumbersFromListTwo()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 1;
            int value5 = 5;
            int value6 = 6;
            int expected1 = 3;
            int expected2 = 5;

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            CustomList<int> result = list1 - list2;

            //assert
            Assert.AreEqual(expected1, result[0]);
            Assert.AreEqual(expected2, result[1]);
        }

        [TestMethod]
        public void MinusOperator_TwoIntLists_CountUpdatedWhenItemRemoved()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 1;
            int value5 = 5;
            int value6 = 6;
            int expected = 2;

            //act
            list1.Add(value1);
            list1.Add(value3);
            list1.Add(value5);
            list2.Add(value2);
            list2.Add(value4);
            list2.Add(value6);
            CustomList<int> result = list1 - list2;

            //assert
            Assert.AreEqual(expected, result.Count);
        }

        [TestMethod]
        public void MinusOperator_TwoIntListsWithMultipleSameNumbers_OnlyOneValueDeleted()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 1;
            int value5 = 5;
            int value6 = 6;
            int expected1 = 1;
            int expected2 = 2;

            //act
            list1.Add(value1);
            list1.Add(value1);
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list2.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            CustomList<int> result = list1 - list2;

            //assert
            Assert.AreEqual(expected1, result[0]);
            Assert.AreEqual(expected1, result[1]);
            Assert.AreEqual(expected2, result[2]);
        }

        [TestMethod]
        public void MinusOperator_TwoIntListsFirstOneEmpty_ReturnEmptyList()
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
            int expected = 0;

            //act
            list2.Add(value1);
            list2.Add(value2);
            list2.Add(value3);
            list2.Add(value4);
            list2.Add(value5);
            list2.Add(value6);
            CustomList<int> result = list1 - list2;

            //assert
            Assert.AreEqual(expected, result.Count);
        }

        [TestMethod]
        public void MinusOperator_ThreeLists_ResultListSubtractsFromBothLists()
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
            int expected = 3;
            int expectedCount = 1;

            //act
            list1.Add(value1);
            list1.Add(value2);
            list1.Add(value3);
            list2.Add(value1);
            list2.Add(value3);
            list2.Add(value4);
            list3.Add(value2);
            list3.Add(value5);
            list3.Add(value6);
            CustomList<int> result = list1 - list2 - list3;

            //assert
            Assert.AreEqual(expected, result[0]);
            Assert.AreEqual(expectedCount, result.Count);
        }
    }
}
