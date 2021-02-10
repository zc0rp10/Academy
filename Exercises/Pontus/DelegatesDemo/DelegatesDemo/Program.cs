using System;
using System.IO;
using System.Linq;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var fs = new FileSearcher();

            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            
            // Named Method
            fs.ListFilesInDirectory(dirPath, FilterTextFiles);

            // Lambda
            fs.ListFilesInDirectory(dirPath, f => Path.GetExtension(f) == ".txt");
        }

        static bool FilterTextFiles(string filePath)
        {
            return Path.GetExtension(filePath).ToLower() == ".txt";
        }

        
    }
}
