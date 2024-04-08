using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unit_8_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\\User\\Luft\\SkillFactoryNew";
            if (Directory.Exists(path))
            {


                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    Console.WriteLine($"В папке: {path}");

                    Console.WriteLine($"Всего {DirectoryExtinsion.DirSize(dirInfo)} байт");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Произошла ошибка: {e}"); ; ;
                }
            }
        }
            

        public static class DirectoryExtinsion
        {
            public static long DirSize(DirectoryInfo d)
            {
                long size = 0;
                FileInfo[] fis = d.GetFiles();
                foreach (FileInfo fi in fis)
                {
                    size += fi.Length;
                }

                DirectoryInfo[] dirs = d.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    size += DirSize(dir);
                }
                return size;
            }
        }

    }
}