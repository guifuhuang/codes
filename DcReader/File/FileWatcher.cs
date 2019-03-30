using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DcCommon.Helper;
using DcReader.Common;

namespace DcReader.File
{
    class FileWatcher: IDisposable
    {

        public FileStack CurrentFileStack
        {
            get;set;
        }
        //public FileWatcher(FileStack fileStack)
        //{
        //    this.CurrentFileStack = fileStack;
        //}
        private FileSystemWatcher watcher = null;
        private static FileWatcher fileWatcher = new FileWatcher();
        private FileWatcher()
        {}
        public static FileWatcher GetInstance()
        {
            return fileWatcher;
        }
        public void Start(string path)
        {
            if (this.watcher == null)
            {
                this.Init(path);
            }
            
            //this.watcher = new FileSystemWatcher(path);
            ///* Watch for changes in LastAccess and LastWrite times, and
            //   the renaming of files or directories. */
            //this.watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
            //   | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            //// Only watch text files.
            //this.watcher.Filter = "*.*";
            //this.watcher.IncludeSubdirectories = false;
            // Add event handlers.
            //this.watcher.Changed += new FileSystemEventHandler(OnChanged);
            //this.watcher.Created += new FileSystemEventHandler(OnCreated);
            //this.watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            //this.watcher.Renamed += new RenamedEventHandler(OnRenamed);
            // Begin watching.
            this.watcher.EnableRaisingEvents = true;
        }
        
        public void Init(string path)
        {
            this.watcher = new FileSystemWatcher(path);
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            this.watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            this.watcher.Filter = "*.*";
            this.watcher.IncludeSubdirectories = false;
            // Add event handlers.
            this.watcher.Changed += new FileSystemEventHandler(OnChanged);
            this.watcher.Created += new FileSystemEventHandler(OnCreated);
            this.watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            this.watcher.Renamed += new RenamedEventHandler(OnRenamed);
        }
        public void Stop()
        {
            //this.watcher.Changed -= new FileSystemEventHandler(OnChanged);
            //this.watcher.Created -= new FileSystemEventHandler(OnCreated);
            //this.watcher.Deleted -= new FileSystemEventHandler(OnDeleted);
            //this.watcher.Renamed -= new RenamedEventHandler(OnRenamed);
            this.watcher.EnableRaisingEvents = false;
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            LogHelper.Info("GenerateDialog:监控更新文件:{0}", e.FullPath);
            FileSystemWatcher watcher = (FileSystemWatcher)source;
            if (watcher != null)
            {
                Console.WriteLine("文件改变事件处理逻辑{0}  {1}  {2}", e.ChangeType, e.FullPath, e.Name);
                Console.WriteLine("最后更新时间:{0}", System.IO.File.GetLastWriteTime(e.FullPath).DateTimeToyyyy_MM_dd_HH_mm_ss_fff());

                DcFileSystemEventArgs dcFile = new DcFileSystemEventArgs(e);
                if (!this.CurrentFileStack.Contains(dcFile))
                {
                    this.CurrentFileStack.Add(dcFile);
                }
            }
        }
        private void OnRenamed(object source, FileSystemEventArgs e)
        {
            LogHelper.Info("GenerateDialog:监控修改文件名:{0}", e.FullPath);
            FileSystemWatcher watcher = (FileSystemWatcher)source;
            if (watcher != null)
            {
                Console.WriteLine("文件重命名事件处理逻辑{0}  {1}  {2}", e.ChangeType, e.FullPath, e.Name);
                Console.WriteLine("最后更新时间:{0}", System.IO.File.GetLastWriteTime(e.FullPath).DateTimeToyyyy_MM_dd_HH_mm_ss_fff());
            }
        }
        private void OnCreated(object source, FileSystemEventArgs e)
        {
            LogHelper.Info("GenerateDialog:监控生成文件:{0}", e.FullPath);
            FileSystemWatcher watcher = (FileSystemWatcher)source;
            if (watcher != null) {
                Console.WriteLine("文件新建事件处理逻辑 {0}  {1}  {2}", e.ChangeType, e.FullPath, e.Name);
                Console.WriteLine("最后更新时间:{0}", System.IO.File.GetLastWriteTime(e.FullPath).DateTimeToyyyy_MM_dd_HH_mm_ss_fff());
                DcFileSystemEventArgs dcFile = new DcFileSystemEventArgs(e);
                if (!this.CurrentFileStack.Contains(dcFile))
                {
                    this.CurrentFileStack.Add(dcFile);
                }
            }
        }
        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            LogHelper.Info("GenerateDialog:删除处理完成的文件:{0}", e.FullPath);
            FileSystemWatcher watcher = (FileSystemWatcher)source;
            if (watcher != null) {
                Console.WriteLine("文件删除事件处理逻辑{0}  {1}   {2}", e.ChangeType, e.FullPath, e.Name);
                Console.WriteLine("最后更新时间:{0}", System.IO.File.GetLastWriteTime(e.FullPath).DateTimeToyyyy_MM_dd_HH_mm_ss_fff());
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                    LogHelper.Info("停止监控目录");
                    Console.WriteLine("停止监控目录");
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~FileWatcher() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
