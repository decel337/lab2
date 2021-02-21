using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public static class RatingCalculator
    {
        public static List<Student> CompileRating(List<Student> students, int percentage)
        {
            SortStudentsForRating(students);
            int lastIn = (int) Math.Floor(students.Count * percentage / 100f);
            List<Student> result = new List<Student>();
            for (int i = 0; i < lastIn; i++)
            {
                result.Add(students[i]);
            }
            return result;
        }

        private static void SortStudentsForRating(List<Student> students)
        {
            MergeStudentUtility.MergeSortStudents(students, 0, students.Count - 1);
        }

        private static class MergeStudentUtility
        {

            public static void MergeSortStudents(List<Student> students, int l, int r)
            {
                if (r > l)
                {
                    int m = (l + r) / 2;
                    MergeSortStudents(students, l, m);
                    MergeSortStudents(students, m + 1, r);
                    MergeStudents(students, l, m, r);
                }
            }
            private static void MergeStudents(List<Student> students, int l, int m, int r)
            {
                int i = 0, j = 0, k = l;
                Student[] L = new Student[m - l + 1];
                Student[] R = new Student[r - m];
                // copy into L and R
                for (; i < L.Length; i++)
                {
                    L[i] = students[l + i];
                }
                for (; j < R.Length; j++)
                {
                    R[j] = students[m + 1 + j];
                }
                i = 0; j = 0;

                // merge into students
                while (i < L.Length && j < R.Length)
                {
                    if (!(L[i].isContract && !R[j].isContract) && ((!L[i].isContract && R[j].isContract) || L[i].GetAverage() > R[j].GetAverage())) // student from L should be higher than from R
                    {
                        students[k] = L[i];
                        i++;
                    }
                    else
                    {
                        students[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // merge remaining students
                while (i < L.Length)
                {
                    students[k] = L[i];
                    i++;
                    k++;
                }
                while (j < R.Length)
                {
                    students[k] = R[j];
                    j++;
                    k++;
                }
            }
        }
    }
}
