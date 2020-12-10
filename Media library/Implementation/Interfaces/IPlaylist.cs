using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public interface IPlaylist
    {
        public Guid Id { get; set; }
        string Name { get; set; }
        int Size { get; set; }
        public System.Collections.Generic.List<File> Files { get; set; }
        void Sort();
        void Add(File file);
        void Remove(File file);
        File[] Search(string nameToSearch);
    }
}