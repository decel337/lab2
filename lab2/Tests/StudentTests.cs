using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestStringConversion()
        {
            Assert.AreEqual(new Student("Vasia", new int[] { 30, 40, 90, 22, 100 }, false).ToString(), "Vasia,30,40,90,22,100,FALSE");
            Assert.AreEqual(new Student("Vasia", new int[] { 30, 40, 90 }, false).ToString(), "Vasia,30,40,90,FALSE");
            Assert.AreEqual(new Student("Vasia", new int[] { 30, 40, 90, 22, 100 }, true).ToString(), "Vasia,30,40,90,22,100,TRUE");
        }

        [TestMethod]
        public void TestListConversion()
        {
            List<Student> students = new List<Student>() {
            new Student("Vasia", new int[] { 30, 40, 90, 22, 100 }, false),
            new Student("Vasia", new int[] { 30, 40, 90 }, false),
            new Student("Vasia", new int[] { 30, 40, 90, 22, 100 }, true),
            };
            string result = "Vasia,30,40,90,22,100,FALSE\n" + "Vasia,30,40,90,FALSE\n" + "Vasia,30,40,90,22,100,TRUE\n";
            Assert.AreEqual(Student.ListToTable(students), result);
            Assert.AreEqual(Student.ListToTable(Student.GenerateStudentList(result.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList())),
                result);
        }
    }
}
