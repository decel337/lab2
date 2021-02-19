using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public static class RatingCalculator
    {

        private class Student
        {
            private string name;
            private int[] grades;
            private bool isContract;

            public Student(string name, int[] grades, bool isContract)
            {
                this.name = name;
                this.grades = grades;
                this.isContract = isContract;
            }
        }
    }
}
