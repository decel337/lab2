using System;
using System.Collections.Generic;
using System.IO;
namespace lab2
{
    public class FileWork
    {
        public static List<string> ReadFiles()
        {
            List<string> InfoOfStudents = new List<string>();
            DirectoryInfo DirInfo = new DirectoryInfo(@"D:\Новая папка (2)\lab2\lab2\lab2\input");
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
    }
}