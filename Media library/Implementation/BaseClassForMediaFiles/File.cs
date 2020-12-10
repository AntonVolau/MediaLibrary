using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public abstract class File : IFile
    {
        public Guid Guid { get; set; }
        /// <summary>
        /// Name of a file
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Size of a file
        /// </summary>
        public decimal Size { get; set; }

        /// <summary>
        /// Path to the file
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Type of a file
        /// </summary>
        public virtual string Type { get; set; }

        public abstract void Accept();
    }
}