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
        void Add(IFile file);
        void Remove(IFile file);
        File[] Search(string nameToSearch);
    }
}