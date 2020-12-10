using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public sealed class Music : File
    {

        /// <summary>
        /// Year of release
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// Author of a song
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Length of a song
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Genre of a song
        /// </summary>
        public string Genre { get; set; }
        public override string Type
        {
            get => base.Type = "mp3";
            set => base.Type = value;
        }

        public override void Accept()
        {
            // код для принятия медиафайлов типа музыки.
        }
    }
}