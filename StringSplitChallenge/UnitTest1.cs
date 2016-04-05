using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSplitChallenge
{
    [TestClass]
    public class UnitTest1
    {
        public string LastName(string fullname)
        {
            var nameList = fullname.Split(' ');
            var last = nameList.Length - 1;
            return nameList[last];  
        }


        public string FirstName(string fullname)
        {
            var nameList = fullname.Split(' ');
            if (nameList.Length <= 2)
            {
                return nameList[0];
            }
            else
            {
                var complexFirstName = nameList[0];
                for (var i = 1; i < nameList.Length - 1; i++)
                {
                    complexFirstName += $" {nameList[i]}";
                }
                return complexFirstName;
            }
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
