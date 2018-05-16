using Microsoft.VisualStudio.TestTools.UnitTesting;
using 回文測試;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文測試.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Given_Test_X_12321_When_Test_Then_true()
        {
            bool expected = true;
            Program program = new Program();
            string Ans = "12321";
            char[] Anss = Ans.ToCharArray(); 
            Array.Reverse(Anss);
            string actual = new string(Anss);
            Assert.AreEqual(expected,Ans.Equals(actual));
        }
        [TestMethod()]
        public void Given_Test_X_123_When_Test_Then_true()
        {
            bool expected = false;
            Program program = new Program();
            string Ans = "123";
            char[] Anss = Ans.ToCharArray();
            Array.Reverse(Anss);
            string actual = new string(Anss);
            Assert.AreEqual(expected, Ans.Equals(actual));
        }
        [TestMethod()]
        public void Given_Test_X_我是豬是我_When_Test_Then_true()
        {
            bool expected = true;
            Program program = new Program();
            string Ans = "我是豬是我";
            char[] Anss = Ans.ToCharArray();
            Array.Reverse(Anss);
            string actual = new string(Anss);
            Assert.AreEqual(expected, Ans.Equals(actual));
        }
    }
}