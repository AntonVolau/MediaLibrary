using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.Implementation.DataModels
{
    public interface IPlaylist<File>
    {
        public Guid Id { get; set; }
        string Name { get; set; }
        int Size { get; set; }
        void Sort();
        void Add(File file);
        void Remove(File file);
        File GetFile(int filePosition);
        List<File> Search(string nameToSearch);
    }
}