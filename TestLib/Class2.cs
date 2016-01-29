using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestLib
{
    public class SecondTests
    {
        internal static int a;

        [Test]
        public void StringComparingCaseSensitive()
        {
            bool result = "some string" == "some string";
            Assert.False(result);
        }

        public void IfStringIsNull_length()
        {
            string nullstr = null;
           // Assert.Throws<NullReferenceException>(, nullstr.Length())
        }

        [Test]
        public void IfStringConaintInt()
        {
            MatchCollection matches = Regex.Matches("12 34 56", @"\d+");

            Assert.AreEqual(3, matches.Count);
            Assert.AreEqual("12", matches[0].Value);

        }

        [Test]
        public void TestTest1()
        {
            a = new Random().Next(100);
            Assert.Greater(a, 50);


        }

        [Test]
        public void TestTest2()
        {
            Assert.Greater(a, 10);
            Assert.AreEqual(a, 99);

        }

    }
}
