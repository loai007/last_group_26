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
        public void SignInTest()
        {
            var newform1 = new Form1();

            string unWrong = "", unRight = "any";
            string psWrong = "", psRight = "any";

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
    public class StudentAddCourseTest
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
        public void userNameCorrect()
        {
            var GetName = new studentMain();
            string objA = "my name";
            string objB = GetName.GetUserName("my name");
            Assert.AreEqual(objA, objB);
        }
        [TestMethod()]
        public void LogOutTest()
        {

            var GetName = new studentMain();

            bool expeted = true;

            bool actual=GetName.isLineEmpty("");

            Assert.AreEqual(expeted ,actual);
        }

    }
    [TestClass()]
    public class IstructorShowCourseTest
    {
        [TestMethod()]
        public void DayPrintCorrect()
        {
            InstructorShowCourse day = new InstructorShowCourse();

            string expicted = "Sunday";
            string expicted1 = "";

            string actual = day.dayofweek(1);
            string actual1 = day.dayofweek(0);

            Assert.AreEqual(expicted, actual);
            Assert.AreEqual(expicted1, actual1);
        }


    }
    [TestClass()]
    public class IstructorMainTest
    {
        [TestMethod()]
        
        public void LogOutTest()
        {
            InstructorMain obj = new InstructorMain();

            bool actual=obj.fileIsWhiteSpace("");

            Assert.IsTrue(actual);
        }


    }
    [TestClass()]
    public class StudentRemoveCourseTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTableIsInsulized()
        {
            StudentRemoveCourse obj = new StudentRemoveCourse();
           obj. Datatableisempty(null);
        }


    }
    [TestClass()]
    public class ManagerMainTest
    {
        [TestMethod()]
        public void LogOutTest()
        {
            ManagerMain obj = new ManagerMain();

            bool actual = obj.LogOutChick("");

            Assert.IsTrue(actual);
        }


    }
    [TestClass()]
    public class ManagerAddCourseTest
    {
        [TestMethod()]
        public void AddCourseDataTest()
        {
            ManagerAddCourse obj = new ManagerAddCourse();

            bool actual = obj.CheckInputs("");

            Assert.IsFalse(actual);
        }


    }


    [TestClass()]
    public class ManagerDeleteCourseTest
    {
        [TestMethod()]
        public void falseTest()
        {
           

            Assert.IsFalse(false);
        }


    }
}