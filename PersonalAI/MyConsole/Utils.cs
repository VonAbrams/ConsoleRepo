using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Utils
    {
        public Utils()
        {

        }
    }
    public class DirectoryFiles : EventArgs
    {
        public enum DayOfWeek { Monday };

        public DirectoryFiles()
        {
            System.Console.WriteLine($"The date is {DayOfWeek.Monday}");

        }
        string[] fileExts = { @"C:\", @"D:\" };
        public static string GetCurrentDirectory(string path)
        {
            path = Directory.GetCurrentDirectory();
            return path;
        }

        public static async Task DisplayCurrentInfoAsync()
        {
            await Task.Delay(5000);
            WaitAndApologizeAsync();
            System.Console.WriteLine($"1");
            System.Console.WriteLine($"2");
            System.Console.WriteLine($"3");
        }
        static async Task WaitAndApologizeAsync()
        {
            await Task.Delay(2000);
        }
        public static void FindDirectoryFiles(string path)
        {
            string[] newPath = Directory.GetFiles(path);
            foreach (var item in newPath)
            {
                Console.WriteLine(item);
            }
        }

        public static async Task ShowTodaysInfoAsync()
        {
            string message = $"{await intTask()}";
            System.Console.WriteLine(message);
        }

        static async Task<int> intTask()
        {
            DayOfWeek today = await Task.FromResult(DayOfWeek.Monday);
            int leisureHours = (int)today;
            return leisureHours;
        }
        public static void FindTextFiles(string path)
        {
            string[] newPath = Directory.GetFiles(path);
            foreach (var item in newPath)
            {
                if (item.EndsWith(".txt"))
                    Console.WriteLine(item);
            }
        }
        public static void FindPNGFiles(string path)
        {
            string[] newPath = Directory.GetFiles(path);
            foreach (var item in newPath)
            {
                if (item.EndsWith(".png"))
                    Console.WriteLine(item);
            }
        }
    }

    class FileDB<T>
    {
        List<T> fileList = new List<T>();


        public object this[int index]
        {

            get { return index; }
            set { }

        }
        public FileDB()
        {
            foreach (var item in fileList)
            {

            }
        }

    }
}

