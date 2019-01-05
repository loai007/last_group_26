using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class studentMainTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetUserNameTest_trowExiption()
        {
            var GetName = new studentMain();
            GetName.GetUserName("");
        }

        [TestMethod()]
        public void GetUserNameTest_shouldWork()
        {
            var GetName = new studentMain();
            string objA="my name";
            string objB = GetName.GetUserName("my name");
            Assert.AreEqual(objA,objB);
        }
    }
}