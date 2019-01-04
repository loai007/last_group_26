using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void checkUsernamePasswordTest()
        {
            string unWrong = "", unRight = "any";
            string psWrong = "", psRight = "any";
            var newform1 = new Form1();
            newform1.checkUsernamePassword(unWrong, psRight);
            newform1.checkUsernamePassword(unWrong, psWrong);
            newform1.checkUsernamePassword(unRight, psWrong);
            //Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void creatdocTestLine()
        {

            var newform1 = new Form1();
            string  rightPath = "user.txt", emptyline ="";
            newform1.creatdoc(emptyline, rightPath);
        }
    }
}