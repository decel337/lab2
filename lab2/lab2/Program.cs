﻿using System;
using System.Collections.Generic;
using lab2;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = Console.ReadLine();
            List<string> StudentsInfo = FileWork.ReadFiles(path);
            List<Student> StudentsForRate = Student.GenerateStudentList(StudentsInfo);
            List<Student> ProcessingStudents = RatingCalculator.CompileRating(StudentsForRate, 40);
            List<string> ProcessStudents = new List<string>();
            foreach (var student in ProcessingStudents)
            {
                ProcessStudents.Add(student.ToString());
            }
            FileWork.WriteFile(ProcessStudents, path);
        }
    }
}