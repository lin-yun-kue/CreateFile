using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempPath = Path.GetTempPath();

            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var date = DateTime.Now.Day;

            tempPath += $"{year}{month}{date}_KyleLin.txt";

            using (var fileStream = File.Create(tempPath))
            {
                var info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                fileStream.Write(info, 0, info.Length);
            }

                Console.ReadLine();
        }
    }
}
