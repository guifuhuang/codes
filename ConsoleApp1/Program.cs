using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter remove chars!:");
            string chars = Console.ReadLine();
            List<string> lstFile = new List<string>();
            string[] currFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            //string currDate = System.DateTime.Today.AddDays(-1*iDay).ToString("yyyyMMdd");
            for (int i = 0; i < currFiles.Length; i++)
            {
                FileInfo fi = new FileInfo(currFiles[i]);
                if (fi.Name.Contains(chars))
                {
                    lstFile.Add(currFiles[i]);
                    Console.WriteLine(currFiles[i]);
                }
            }
            if (lstFile.Count > 0)
            {
                Console.WriteLine("Are you sure modify these file names? Y/N");
                string yorn = Console.ReadLine();
                if (yorn.ToUpper() == "Y")
                {
                    Console.WriteLine("Start remove chars...");
                    for (int i = 0; i < lstFile.Count; i++)
                    {
                        FileInfo fi = new FileInfo(lstFile[i]);
                        fi.CopyTo(fi.Name.Replace(chars, ""));
                        fi.Delete();
                    }
                    Console.WriteLine("Start remove chars...");
                    Console.WriteLine("Remove chars completed!");
                }
                else
                {
                    Console.WriteLine("Press any key to exit...");
                }
            }
            else
            {
                Console.WriteLine("No file found.");
            }
            Console.ReadLine();
        }
    }
}
