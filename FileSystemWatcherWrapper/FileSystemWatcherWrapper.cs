using System;
using System.IO;

namespace FileSystemWatcherWrapper
{
    /// <summary>
    /// Wrapper for the FileSystemWatcher class
    /// </summary>
    public class FileSystemWatcherWrapper : FileSystemWatcher, IFileSystemWatcher
    {
        /// <summary>
        /// Initializes a new instance of the FileSystemWatcherWrapper class.
        /// </summary>
        public FileSystemWatcherWrapper()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FileSystemWatcherWrapper class, given the specified directory to monitor.
        /// </summary>
        /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
        /// <exception cref="System.ArgumentNullException">The path parameter is null.</exception>
        /// <exception cref="System.ArgumentException">The path parameter is an empty string ("").-or- The path specified through the path parameter does not exist.</exception>
        public FileSystemWatcherWrapper(string path)
            : base(path)
        {            
        }
        
        /// <summary>
        /// Initializes a new instance of the FileSystemWatcherWrapper class, given the specified directory and type of files to monitor.
        /// </summary>
        /// <param name="path">The directory to monitor, in standard or Universal Naming Convention (UNC) notation.</param>
        /// <param name="filter">The type of files to watch. For example, "*.txt" watches for changes to all text files.</param>
        /// <exception cref="System.ArgumentNullException">The path parameter is null.</exception>
        /// <exception cref="System.ArgumentException">The path parameter is an empty string ("").-or- The path specified through the path parameter does not exist.</exception>
        public FileSystemWatcherWrapper(string path, string filter)
            : base(path, filter)
        {       
        }                 
    }
}
