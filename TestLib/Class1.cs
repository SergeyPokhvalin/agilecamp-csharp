using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class FirstTests
    {
        [Test]
        public void FirstSuccessTest()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void FirstFailTest()
        {
            Assert.True(false);
        }

        [Test]
        public void SecondSuccessTest()
        {
            Assert.IsEmpty(String.Empty);
        }

        [Test]
        public void SecondFailTest()
        {
            var a = new object();
            var b = new object();
            Assert.AreSame(a,b);
        }
    }
}
