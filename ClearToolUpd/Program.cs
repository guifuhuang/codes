using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ClearToolUpd
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;
            if (args.Length != 0)
            {
                filePath = args[0];
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                FileInfo[] files = di.GetFiles("*.updt");
                if (files.Length == 0)
                {
                    Console.WriteLine("Please enter the file's name path!");
                    filePath = Console.ReadLine();
                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine("The file is not exist!");
                        Console.ReadLine();
                        return;
                    }
                }
                else
                {
                    List<string> lstFile = new List<string>();
                    foreach (FileInfo fi in files)
                    {
                        lstFile.Add(fi.FullName);
                    }
                    lstFile.Sort();
                    filePath = lstFile[lstFile.Count - 1];
                }
            }
            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine("The file name is Empty!");
                Console.ReadLine();
                return;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string data = reader.ReadToEnd();
                reader.Close();
                string[] lineArray = data.Split('\n');
                
                using (Process process = new System.Diagnostics.Process())
                {
                    process.StartInfo.FileName = "cleartool";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    for(int i=0;i<lineArray.Length;i++)
                    {
                        if(string.IsNullOrWhiteSpace(lineArray[i]))
                        {
                            Console.WriteLine("Line:"+i.ToString()+" is NullOrWhiteSpace!");
                            continue;
                        }
                        if(!lineArray[i].StartsWith("New:") && !lineArray[i].StartsWith("Updated:"))
                        {
                            Console.WriteLine("Line:"+i.ToString()+" is NotStartNewOrUpdated!");
                            continue;
                        }
                        string content = string.Empty;
                        string targetFile = lineArray[i].Split(':')[1].Trim().Split(' ')[0];
                        process.StartInfo.Arguments = "update -overwrite " + targetFile;
                        process.Start();
                        
                        Console.WriteLine(process.StandardOutput.ReadToEnd());
                    }
                }
            }
        }
    }
}
