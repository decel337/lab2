using System;
using System.Collections.Generic;
using System.IO;
namespace lab2
{
    public class FileWork
    {
        public static List<string> ReadFiles(string path)
        {
            List<string> InfoOfStudents = new List<string>();
            DirectoryInfo DirInfo = new DirectoryInfo(path);
            FileInfo[] files = DirInfo.GetFiles("*.csv");

            foreach (var file in files)
            {
                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        InfoOfStudents.Add(reader.ReadLine());
                    }
                }
            }
            return InfoOfStudents;
        }

        public static void WriteFile(List<string> ProcInfoStudents, string path)
        {
            using (StreamWriter result = new StreamWriter(path + "/result.csv"))
            {
                foreach (var student in ProcInfoStudents)
                {
                    result.WriteLine(student);
                }
            }
        }
    }
}