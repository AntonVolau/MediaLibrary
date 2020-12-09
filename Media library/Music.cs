using System;
using System.Collections.Generic;
using System.Text;

namespace Media_library
{
    public class Music : File
    {

        private string Year
        {
            get => default;
            set
            {
                string year;
            }
        }

        private string Artist
        {
            get => default;
            set
            {
                string artist;
            }
        }

        private int Length
        {
            get => default;
            set
            {
                int length;
            }
        }

        private string Genre
        {
            get => default;
            set
            {
                string genre;
            }
        }

        public Music(string type, string name, int size, string location, // File
            string year, string artist, int length, string genre) : // Photo
            base(type, name, size, location)
        {
            Year = year;
            Artist = artist;
            Length = length;
            Genre = genre;
        }
    }
}