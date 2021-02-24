using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student
    {
        private string name;
        private int[] grades;
        public bool isContract { get; private set; }

        public Student(string name, int[] grades, bool isContract)
        {
            this.name = name;
            this.grades = grades;
            this.isContract = isContract;
        }

        // accepts a string in the following format: "Ivanov,78,61,95,87,90,FALSE"
        public Student(string record)
        {
            string[] split = record.Split(',');
            int[] grades = new int[split.Length - 2];
            for (int i = 1; i < split.Length - 1; i++)
            {
                grades[i - 1] = Convert.ToInt32(split[i]);
            }
            bool isContract = split[split.Length - 1] == "FALSE" ? false : true;
            this.name = split[0];
            this.grades = grades;
            this.isContract = isContract;
        }

        

        public float GetAverage()
        {
            int total = 0;
            foreach (int grade in grades)
            {
                total += grade;
            }
            return (float)total / grades.Length;
        }

        public override string ToString()
        {
            string result = name + ";";
            result += Math.Round(GetAverage(), 3);
            return result;
        }
    }
}
