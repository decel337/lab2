using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class StudentFactory
    {
        // accepts an list of strings in the following format: "Ivanov,78,61,95,87,90,FALSE"
        public List<Student> GenerateStudentList(List<string> records)
        {
            List<Student> result = new List<Student>();
            foreach (string record in records)
            {
                result.Add(new Student(record));
            }
            return result;
        }
    }
}
