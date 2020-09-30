using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ToString_TwoStrings_CombinedStringHelloWorld()
        {
            //arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "HelloWorld";
            string value1 = "Hello";
            string value2 = "World";

            //act
            list.Add(value1);
            list.Add(value2);
            string actual = list.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ThreeInts_String123()
        {
            //arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "123";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            //act
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            string actual = list.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_FiveChars_StringDylan()
        {
            //arrange
            CustomList<char> list = new CustomList<char>();
            string expected = "Dylan";
            char d = 'D';
            char y = 'y';
            char l = 'l';
            char a = 'a';
            char n = 'n';

            //act
            list.Add(d);
            list.Add(y);
            list.Add(l);
            list.Add(a);
            list.Add(n);
            string actual = list.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_EmptyList_EmptyString()
        {
            //arrange
            CustomList<char> list = new CustomList<char>();

            //act
            string actual = list.ToString();

            //assert
            Assert.AreEqual("", actual);
        }

    }
}
