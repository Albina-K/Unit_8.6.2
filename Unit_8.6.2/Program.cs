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
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\User\\Luft\\SkillFactoryNew");

                WriteFolderInfo(dirInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e}"); ; ;
            }

            /*DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives.Where(d.DriveInfo => d.DriveType == DriveType.Fixed)
            {
                DirectoryInfo root = drive.RootDirectory;
                var folders.DirectoryInfo[] = root.GetDirectories();
            }*/





            // DirectoryInfo dirName = new DirectoryInfo(@"C:\\User\\Luft\\SkillFactoryNew");





            /*   if (Directory.Exists(@"C:\\User\\Luft\\SkillFactoryNew"))
               {
                   try
                   {
                       string dirName = @"C:\\User\\Luft\\SkillFactoryNew";
                       WriteFolderInfo(dirName);
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine($"Произошла ошибка: {ex.Message}");
                   }
               }*/
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

       
            public static void WriteFolderInfo(DirectoryInfo[] folders)
            {
                foreach (DirectoryInfo folder in folders)
                {
                    try
                    {
                        Console.WriteLine(DirectoryExtinsion.DirSize(folder));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Произошла ошибка: {e}");
                    }
                }
            }

           
    

    }
}