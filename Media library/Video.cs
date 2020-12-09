using System;
using System.Collections.Generic;
using System.Text;

namespace Media_library
{
    public class Video : File
    {

        private int Length
        {
            get => default;
            set
            {
                int length;
            }
        }

        private string FileType
        {
            get => default;
            set
            {
                string fileType;
            }
        }

        private int Height
        {
            get => default;
            set
            {
                int height;
            }
        }

        private int Width
        {
            get => default;
            set
            {
                int width;
            }
        }

        public Video(string type, string name, int size, string location, // File
            int width, int height, string fileType, int length) : // Photo
            base(type, name, size, location)
        {
            FileType = fileType;
            Length = length;
            Width = width;
            Height = height;
        }
    }
}