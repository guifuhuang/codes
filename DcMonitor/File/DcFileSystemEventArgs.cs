using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DcMonitor.File
{
    //
    // 摘要:
    //     Provides data for the directory events: System.IO.FileSystemWatcher.Changed,
    //     System.IO.FileSystemWatcher.Created, System.IO.FileSystemWatcher.Deleted.
    public class DcFileSystemEventArgs
    {
        private FileSystemEventArgs _fileSystemEventArgs = null;
        private DateTime _lastWriteTime = System.DateTime.Now;

        //
        // 摘要:
        //     Initializes a new instance of the System.IO.DcFileSystemEventArgs class.
        //
        // 参数:
        //   changeType:
        //     One of the System.IO.WatcherChangeTypes values, which represents the kind of
        //     change detected in the file system.
        //
        //   directory:
        //     The root directory of the affected file or directory.
        //
        //   name:
        //     The name of the affected file or directory.
        public DcFileSystemEventArgs(FileSystemEventArgs args)
        {
            this._fileSystemEventArgs = args;
            this._lastWriteTime= System.IO.File.GetLastWriteTime(args.FullPath);
        }
        //
        // 摘要:
        //     Gets the type of directory event that occurred.
        //
        // 返回结果:
        //     One of the System.IO.WatcherChangeTypes values that represents the kind of change
        //     detected in the file system.
        public WatcherChangeTypes ChangeType
        {
            get
            {
                return this._fileSystemEventArgs.ChangeType;
            }
        }
        //
        // 摘要:
        //     Gets the fully qualifed path of the affected file or directory.
        //
        // 返回结果:
        //     The path of the affected file or directory.
        public string FullPath
        {
            get
            {
                return this._fileSystemEventArgs.FullPath;
            }
        }
        //
        // 摘要:
        //     Gets the name of the affected file or directory.
        //
        // 返回结果:
        //     The name of the affected file or directory.
        public string Name
        {
            get
            {
                return this._fileSystemEventArgs.Name;
            }
        }
        /// <summary>
        /// 该事件文件的最后更新时间
        /// </summary>
        public DateTime LastWriteTime
        {
            get
            {
                return this._lastWriteTime;
            }
        }
    }
}
