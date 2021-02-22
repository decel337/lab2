using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab2.Tests
{
    [TestClass]
    public class RatingCalculatorTests
    {
        [TestMethod]
        public void TestRatingAllBudget()
        {
            List<Student> students = new List<Student>() {
            new Student("Vasia", new int[] { 30, 40, 90, 22, 100 }, false),
            new Student("Vasia1", new int[] { 30, 40, 90, 150, 3000 }, false),
            new Student("Vasia2", new int[] { 30, 40, 0, 22, 0 }, false),
            };
            string records = $"{students[1].ToString()}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 40)), records);
            records += $"{students[0]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 70)), records);
            records += $"{students[2]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 100)), records);
        }

        [TestMethod]
        public void TestRatingAllContract()
        {
            List<Student> students = new List<Student>() {
            new Student("Vasia", new int[] { 30, 40, 90, 22, 100 }, true),
            new Student("Vasia1", new int[] { 30, 40, 90, 150, 3000 }, true),
            new Student("Vasia2", new int[] { 30, 40, 0, 22, 0 }, true),
            };
            string records = $"{students[1].ToString()}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 40)), records);
            records += $"{students[0]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 70)), records);
            records += $"{students[2]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 100)), records);
        }

        [TestMethod]
        public void TestRatingMixed()
        {
            List<Student> students = new List<Student>() {
            new Student("Vasia", new int[] { 300000000, 40, 9000, 22, 100 }, true),
            new Student("Vasia1", new int[] { 30, 40, 90, 0, 0 }, true),
            new Student("Vasia2", new int[] { 30, 40, 90, 22, 12 }, true),
            new Student("Vasia3", new int[] { 30, 40, 90, 22, 100 }, false),
            new Student("Vasia4", new int[] { 30, 40, 90, 150, 3000 }, false),
            new Student("Vasia5", new int[] { 30, 40, 0, 22, 0 }, false),
            };
            string records = $"{students[4].ToString()}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 20)), records);
            records += $"{students[3]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 40)), records);
            records += $"{students[5]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 50)), records);
            records += $"{students[0]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 70)), records);
            records += $"{students[2]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 90)), records);
            records += $"{students[1]}\n";
            Assert.AreEqual(Student.ListToTable(RatingCalculator.CompileRating(new List<Student>(students), 100)), records);
        }
    }
}
