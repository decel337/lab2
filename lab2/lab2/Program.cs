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
            FileWork file = new FileWork();
            List<string> StudentsInfo = file.ReadFiles(path);
            if (StudentsInfo.Count != 0)
            {
                List<Student> StudentsForRate = new StudentFactory().GenerateStudentList(StudentsInfo);
                List<Student> ProcessingStudents = new RatingCalculator().CompileRating(StudentsForRate, 40);
                List<string> ProcessStudents = new List<string>();
                foreach (var student in ProcessingStudents)
                {
                    ProcessStudents.Add(student.ToString());
                }

                file.WriteFile(ProcessStudents, path);
            }
            else
            {
                Console.WriteLine("In directory no .csv files");
            }
        }
    }
}