using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.Enums;

namespace MediaLibrary.Implementation.DataModels.DataModelsImplementation
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
        public override MediaFileTypes Type // переопределение типа файла
        {
            get => base.Type = MediaFileTypes.jpeg;
            set => base.Type = value;
        }
    }
}