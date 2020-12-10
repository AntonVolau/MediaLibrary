using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public sealed class Photo : File
    {
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
            get => base.Type = "jpg";
            set => base.Type = value;
        }

        public override void Accept()
        {
            // код для принятия медиафайлов типа фото.
        }
    }
}