using System;
using System.IO;

namespace HgfFileMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromPath = string.Empty;
            string toPath = string.Empty;
            if (args.Length > 2)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
                fromPath = args[0];
                toPath = args[1];
                string filePath = args[2];

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string data = reader.ReadToEnd();
                    reader.Close();

                    string[] lineArray = data.Split('\n');

                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lineArray[i]))
                        {
                            continue;
                        }

                        if (lineArray[i].Contains(fromPath))
                        {
                            string content = string.Empty;
                            string destPath = lineArray[i].Replace(fromPath, toPath).TrimEnd('\n');
                            if (File.Exists(lineArray[i]))
                            {
                                if (File.Exists(destPath))
                                {
                                    content = "#UPD=>" + destPath;
                                }
                                else
                                {
                                    content = "#ADD=>" + destPath;
                                }
                                File.Copy(lineArray[i], destPath, true);
                            }
                            else
                            {
                                if (File.Exists(destPath))
                                {
                                    content = "#DEL=>" + destPath;
                                    File.Delete(destPath);
                                }
                                else
                                {
                                    content = "#DEL=>File Not Found!(" + destPath + ")";
                                    //System.IO.DirectoryInfo DirInfo = new DirectoryInfo("");
                                    //DirInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;

                                    string[] dirs = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory);
                                    
                                    File.SetAttributes("", FileAttributes.Normal);
                                    FileInfo fi = new FileInfo("");
                                    //fi.LastWriteTime
                                }
                            }
                            Console.WriteLine(content);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("parameter error!");
            }
            string sread = Console.ReadLine();
            while (sread != "ok")
            {
                sread = Console.ReadLine();
            }

        }
    }
}
