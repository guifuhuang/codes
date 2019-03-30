using DcCommon.Helper;
using DcReader.Common;
using DcReader.File;
using System;
using System.IO;

namespace DcReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\zjzy\test";
            Console.WriteLine("监控目录:"+path);
            // FileWatcher watcher = new FileWatcher(FileStack.GetInstance());
            FileWatcher watcher = FileWatcher.GetInstance();
            watcher.CurrentFileStack = FileStack.GetInstance();
            watcher.Start(path);
            string sread = Console.ReadLine();
            while (sread != "stop")
            {
                sread = Console.ReadLine();
            }
            Console.WriteLine("停止:Start");
            watcher.Stop();
            //watcher.Dispose();
            Console.WriteLine("停止:End");

            sread = Console.ReadLine();
            if (sread == "start")
            {
                Console.WriteLine("Start");
                watcher.Start(path);
                Console.WriteLine("End");
            }
            sread = Console.ReadLine();
            while (sread != "stop")
            {
                sread = Console.ReadLine();
            }
            Console.WriteLine("停止:Start");
            watcher.Stop();
            //watcher.Dispose();
            Console.WriteLine("停止:End");

        }
    }
}
