using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.Enums;

namespace MediaLibrary.Implementation.DataModels.DataModelsImplementation
{
    public sealed class Video : File
    {
        /// <summary>
        /// Length of a video
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Type of videofile
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// Resolution parameter
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Resolution parameter
        /// </summary>
        public int Width { get; set; }

        public override MediaFileTypes Type // переопределение типа файла
        { 
            get => base.Type = MediaFileTypes.mp4;
            set => base.Type = value;
        }
    }
}