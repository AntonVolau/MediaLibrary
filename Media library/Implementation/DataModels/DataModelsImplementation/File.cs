using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.Enums;

namespace MediaLibrary.Implementation.DataModels.DataModelsImplementation
{
    public abstract class File : IFile
    {
        /// <summary>
        /// ID of file 
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// Name of file
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Size of file
        /// </summary>
        public decimal Size { get; set; }

        /// <summary>
        /// Path to the file
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Type of file
        /// </summary>
        public virtual MediaFileTypes Type { get; set; }
    }
}