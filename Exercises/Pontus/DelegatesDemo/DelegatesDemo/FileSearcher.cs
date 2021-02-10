using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class FileSearcher
    {
        
        public void ListFilesInDirectory(string dirPath, Func<string, bool> predicate)
        //public void ListFilesInDirectory(string dirPath, FileFilter predicate)
        {
            string[] filePaths = Directory.GetFiles(dirPath);

            foreach (var filePath in filePaths)
            {
                if (predicate(filePath))
                    Console.WriteLine(filePath);
            }
        }
    }

    // Namgiven Delegate
    delegate bool FileFilter(string filePath);
}
