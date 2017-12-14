﻿using System;
using System.Collections.Generic;
using System.Text;

namespace f14.AspNetCore.FileManager.Data.Results
{
    /// <summary>
    /// Represents the response data object for the file system struct request.
    /// </summary>
    public class FolderStructResult : BaseResult
    {
        private List<FileInfoProxy> _folders;
        private List<FileInfoProxy> _files;

        /// <summary>
        /// Folders count.
        /// </summary>
        public int FolderCount { get; set; }
        /// <summary>
        /// Files count.
        /// </summary>        
        public int FileCount { get; set; }
        /// <summary>
        /// Folders collection.
        /// </summary>
        public List<FileInfoProxy> Folders
        {
            get
            {
                if (_folders == null)
                {
                    _folders = new List<FileInfoProxy>();
                }
                return _folders;
            }
            set
            {
                _folders = value;
                FolderCount = _folders != null ? _folders.Count : 0;
            }
        }
        /// <summary>
        /// Files collection.
        /// </summary>
        public List<FileInfoProxy> Files
        {
            get
            {
                if (_files == null)
                {
                    _files = new List<FileInfoProxy>();
                }
                return _files;
            }
            set
            {
                _files = value;
                FileCount = _files != null ? _files.Count : 0;
            }
        }
    }
}
