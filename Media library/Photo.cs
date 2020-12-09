using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class Photo : File
    {
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

        public Photo(string type, string name, int size, string location, // File
            int width, int height) : // Photo
            base(type, name, size, location)
        {
            Height = height;
            Width = width;
        }
    }
}