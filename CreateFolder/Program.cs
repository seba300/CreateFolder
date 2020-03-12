using System;

namespace CreateFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create folder

            string path = @"C:\Users\Sebastian\Desktop\NewFolder";
            System.IO.Directory.CreateDirectory(path);
        }
    }
}
