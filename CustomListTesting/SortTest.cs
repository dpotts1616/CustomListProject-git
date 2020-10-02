using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Sort_IntList_AscendingOrderNumbers()
        {
            //arrange
            CustomList<int> list = new CustomList<int>() {2,4,5,3,1,6 };
            string expected = "123456";

            //act
            list.Sort();
            string actual = list.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_IntList_CountStaysSame()
        {
            //arrange
            CustomList<int> list = new CustomList<int>() { 2, 4, 5, 3, 1, 6 };
            int expected = 6;

            //act
            list.Sort();

            //assert
            Assert.AreEqual(expected, list.Count);
        }

        public void Sort_StringList_AlphabeticalOrder()
        {
            //arrange
            CustomList<string> list = new CustomList<string>() { "Dylan", "John", "Bob", "Stacy"};
            string expected1 = "Bob";
            string expected2 = "Dylan";
            string expected3 = "John";
            string expected4 = "Stacy";

            //act
            list.Sort();

            //assert
            Assert.AreEqual(expected1, list[0]);
            Assert.AreEqual(expected2, list[1]);
            Assert.AreEqual(expected3, list[2]);
            Assert.AreEqual(expected4, list[3]);
        }

        public void Sort_StringList_CountStaysSame()
        {
            //arrange
            CustomList<string> list = new CustomList<string>() { "Dylan", "John", "Bob", "Stacy" };
            int expected = 4;

            //act
            list.Sort();

            //assert
            Assert.AreEqual(expected, list.Count);
        }

        public void Sort_CharList_AlphabeticalOrder()
        {
            //arrange
            CustomList<char> list = new CustomList<char>() { 'D', 'B', 'S', 'J' };
            char expected1 = 'B';
            char expected2 = 'D';
            char expected3 = 'J';
            char expected4 = 'S';

            //act
            list.Sort();

            //assert
            Assert.AreEqual(expected1, list[0]);
            Assert.AreEqual(expected2, list[1]);
            Assert.AreEqual(expected3, list[2]);
            Assert.AreEqual(expected4, list[3]);
        }
    }
}
