using System;
using System.Linq;

namespace _03._ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorIndex = file.LastIndexOf('\\');
            int extensionIndex = file.LastIndexOf('.');
            
            if( lastSeparatorIndex != -1 && extensionIndex != -1
                && lastSeparatorIndex < extensionIndex)
            {
                fileName = file.Substring(lastSeparatorIndex + 1,extensionIndex- lastSeparatorIndex - 1);
                fileExtension = file.Substring(extensionIndex + 1);
            
            }
            
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
