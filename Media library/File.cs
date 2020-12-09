using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class File
    {
        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int Size
        {
            get => default;
            set
            {
            }
        }

        public string Location
        {
            get => default;
            set
            {
            }
        }

        public string Type
        {
            get => default;
            set
            {
            }
        }

        public File(string type, string name, int size, string location)
        {
            Name = name;
            Type = type;
            Size = size;
            Location = location;
        }
    }
}