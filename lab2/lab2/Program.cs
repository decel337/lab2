using System;
using System.Collections.Generic;
using lab2;

namespace lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            string path = Console.ReadLine();
            List<string> StudentsInfo = FileWork.ReadFiles(path);
            if (StudentsInfo.Count != 0)
            {
                List<Student> StudentsForRate = Student.GenerateStudentList(StudentsInfo);
                List<Student> ProcessingStudents = new RatingCalculator().CompileRating(StudentsForRate, 40);
                List<string> ProcessStudents = new List<string>();
                foreach (var student in ProcessingStudents)
                {
                    ProcessStudents.Add(student.ToString());
                }

                FileWork.WriteFile(ProcessStudents, path);
            }
            else
            {
                Console.WriteLine("In directory no .csv files");
            }
        }
    }
}