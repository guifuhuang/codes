using System;
using System.Collections.Generic;
using System.IO;

namespace FindFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a ago-day Number:");
            string sDay = Console.ReadLine();
            int iDay = 0;
            if (!int.TryParse(sDay, out iDay))
            {
                Console.WriteLine("Wrong Number!Search Today files!");
                iDay = 0;
            }
            string currDate = System.DateTime.Today.AddDays(-1 * iDay).ToString("yyyyMMdd");
            List<string> lstFile = new List<string>();
            using (StreamWriter sw = File.CreateText(System.DateTime.Now.ToString("yyyyMMdd_hhmmss")))
            {
                lstFile.AddRange(GetFiles(AppDomain.CurrentDomain.BaseDirectory, currDate, sw));
            }
            /*
            Console.WriteLine("Root Path:" + AppDomain.CurrentDomain.BaseDirectory);
            string[] currFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            string currDate = System.DateTime.Today.AddDays(-1 * iDay).ToString("yyyyMMdd");
            for (int i = 0; i < currFiles.Length; i++)
            {
                FileInfo fi = new FileInfo(currFiles[i]);
                if (fi.LastWriteTime.ToString("yyyyMMdd") == currDate)
                {
                    lstFile.Add(currFiles[i]);
                    Console.WriteLine(currFiles[i]);
                }
            }
            string[] dirs = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);
            foreach (string dir in dirs)
            {
                lstFile.AddRange(GetFiles(dir, iDay));
            }
             * */
            Console.ReadLine();
        }

        private static string[] GetFiles(string path, string currDate,StreamWriter sw)
        {
            List<string> lstFile = new List<string>();
            string[] currFiles = Directory.GetFiles(path);
            //string currDate = System.DateTime.Today.AddDays(-1*iDay).ToString("yyyyMMdd");
            for (int i = 0; i < currFiles.Length; i++)
            { 
                FileInfo fi = new FileInfo(currFiles[i]);
                if (fi.LastWriteTime.ToString("yyyyMMdd") == currDate)
                {
                    lstFile.Add(currFiles[i]);
                    Console.WriteLine(currFiles[i]);
                    sw.WriteLine(currFiles[i]);
                }
            }
            if (Directory.GetDirectories(path).Length != 0)
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    lstFile.AddRange(GetFiles(dir, currDate, sw));
                }
            }
            return lstFile.ToArray();
        }
    }
}
