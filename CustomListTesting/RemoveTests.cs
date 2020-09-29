using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class RemoveTests
    {
       //Count is updated correctly
        [TestMethod]
        public void Remove_AddFiveValuesRemoveOne_CountFour()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Remove(value1);
            actual = list.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }


        //remove first instance
        [TestMethod]
        public void Remove_AddFiveValuesRemoveFirstInstance_Value2Deleted()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 2;
            int value5 = 5;
            int expected = 3;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Remove(2);
            actual = list[1];

            //assert
            Assert.AreEqual(expected, actual);
        }


        //item is actually removed from list
        [TestMethod]
        public void Remove_RemoveValueFromList_ValueDeleted()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Remove(3);
            actual = list[2];

            //assert
            Assert.AreEqual(expected, actual);
        }


        //items are moved down in list
        [TestMethod]
        public void Remove_RemoveValueFromList_ValuesAreMovedDownList()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected1 = 3;
            int expected3 = 4;
            int expected4 = 5;
            int actual1;
            int actual3;
            int actual4;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            list.Add(value5);
            list.Remove(2);
            actual1 = list[1];
            actual3 = list[3];
            actual4 = list[4];

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        ////item does not exist to remove
        //[TestMethod]
        //[ExpectedException(typeof(NullReferenceException))]
        //public void Remove_FiveValues_CheckForNullExceptionMissingObject()
        //{
        //    //arrange
        //    CustomList<int> list = new CustomList<int>();
        //    int value1 = 1;
        //    int value2 = 2;
        //    int value3 = 3;
        //    int value4 = 4;
        //    int value5 = 5;

        //    //act
        //    list.Add(value1);
        //    list.Add(value2);
        //    list.Add(value3);
        //    list.Add(value4);
        //    list.Add(value5);
        //    list.Remove(6);

        //    //assert
        //}

        //no items in list
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Remove_NoValues_CheckForNullExceptionMissingObject()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            int index = 6;

            //act
            list.Remove(index);

            //assert
        }

    }
}
