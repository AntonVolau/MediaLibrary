using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
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

        public override string Type 
        { 
            get => base.Type = "mp4";
            set => base.Type = value;
        }

        public override void Accept()
        {
            // код для принятия медиафайлов типа видео.
        }
    }
}