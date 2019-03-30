using DcCommon.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DcMonitor.File
{
    public class FileStack
    {
        private List<DcFileSystemEventArgs> fileList = new List<DcFileSystemEventArgs>();
        public List<DcFileSystemEventArgs> FileList
        {
            private set
            {
                this.fileList = value;
            }
            get
            {
                return this.fileList;
            }
        }
        private static FileStack fileStack = new FileStack();
        private FileStack()
        {
            this.fileList = new List<DcFileSystemEventArgs>();
        }
        public static FileStack GetInstance()
        {
            return fileStack;
        }
        public int Clear()
        {
            int i = this.fileList.Count;
            this.fileList.Clear();
            return i - this.fileList.Count;
        }
        public void Add(DcFileSystemEventArgs file)
        {
            this.fileList.Add(file);
            this.CopyFile(file);
            Console.WriteLine("---------文件列表--------");
            for (int i =0;i< this.fileList.Count;i++)
            {
                Console.WriteLine("文件【{0}】新建事件处理逻辑 {1}  {2}  {3}", (i + 1).ToIntString(), this.fileList[i].ChangeType, this.fileList[i].FullPath, this.fileList[i].LastWriteTime.DateTimeToyyyy_MM_dd_HH_mm_ss_fff());
            }
            Console.WriteLine("-----------结束----------");
        }
        public bool Remove(DcFileSystemEventArgs file)
        {
            return this.fileList.Remove(file);
        }
        public void RemoveAt(int index)
        {
            this.fileList.RemoveAt(index);
        }
        public bool Contains(DcFileSystemEventArgs file)
        {
            foreach (DcFileSystemEventArgs f in this.fileList)
            {
                if (f.Name == file.Name && f.FullPath == file.FullPath && DateTime.Compare(f.LastWriteTime , file.LastWriteTime) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void CopyFile(DcFileSystemEventArgs file)
        {
            // 不能是和监控目录相同或是其子目录，否则可能会引发递触发
            IoHelper.CopyFile(file.FullPath, Path.Combine(@"C:\zjzy\IBM", file.LastWriteTime.DateTimeToyyyyMMddHHmmssfff(), file.Name));
        }
    }
}
