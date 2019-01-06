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
    [TestClass()]
    public class RequestsTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void WriteTOFile_shouldntWork()
        {
            var student = new StudentAddCourse();
            string rightPath = "user.txt", emptyline = "";
            student.writeToFile(rightPath, emptyline);
        }

        [TestMethod()]
        public void checkIsEmpty_shouldWork()
        {
            var student = new StudentAddCourse();

            string[] obj = {"hii"};
            string[] obj1 = { "hii there" };
            bool actual=student.makesureNotEmpty(obj,obj1);

            Assert.IsTrue(actual);

        }
    }
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
            string objA = "my name";
            string objB = GetName.GetUserName("my name");
            Assert.AreEqual(objA, objB);
        }
    }
    [TestClass()]
    public class IstructorShowCourseTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetUserNameTest_trowExiption()
        {
            InstructorShowCourse day = new InstructorShowCourse();

            string expicted = "Sunday";

            string actual=day.dayofweek(1);

            Assert.AreEqual(expicted, actual);
        }

       
    }
}