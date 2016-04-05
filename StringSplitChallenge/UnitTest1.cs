using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSplitChallenge
{
    [TestClass]
    public class UnitTest1
    {
        public string LastName(string fullname)
        {
            var nameList = fullname.Split(' ');
            return nameList[nameList.Length - 1];  
        }


        public string FirstName(string fullname)
        {
            var nameList = fullname.Split(' ').ToList();
            var numOfFirstNames = Math.Max(nameList.Count - 1, 1);

            return string.Join(" ", nameList.GetRange(0, numOfFirstNames));
        }


        [TestMethod]
        public void TestFirstName()
        {
            Assert.AreEqual("Daniel", FirstName("Daniel Pollock"));
        }

        [TestMethod]
        public void TestLastName()
        {
            Assert.AreEqual("Pollock", LastName("Daniel Pollock"));
        }



        [TestMethod]
        public void TestOneWordName()
        {
            Assert.AreEqual("Moby", FirstName("Moby"));
            Assert.AreEqual("Moby", LastName("Moby"));
        }



        [TestMethod]
        public void TestThreeWordName()
        {
            Assert.AreEqual("John Quincy", FirstName("John Quincy Adams"));
            Assert.AreEqual("Adams", LastName("John Quincy Adams"));
        }

        [TestMethod]
        public void TestNoWordName()
        {
            Assert.AreEqual("", FirstName(""));
            Assert.AreEqual("", LastName(""));
        }
    }


}
