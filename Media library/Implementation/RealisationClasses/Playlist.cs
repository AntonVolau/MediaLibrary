using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class Playlist : IPlaylist
    {
        /// <summary>
        /// Id of a list
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Name of a list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Size of a list
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// List of files
        /// </summary>
        public System.Collections.Generic.List<File> Files { get; set; }

        /// <summary>
        /// Method to sort playlist
        /// </summary>
        public void Sort()
        {
            // код для сортировки плэйлиста.
        }

        /// <summary>
        /// Method for adding a file in playlist
        /// </summary>
        public void Add(IFile mediaFile1)
        {
            // код для добавления файла в существующий плэйлист.
        }

        /// <summary>
        /// Method for removing file from playlist
        /// </summary>
        public void Remove(IFile file)
        {
            // код для удаления файла из существующего плэйлиста.
        }

        /// <summary>
        /// Method to search for files
        /// </summary>
        public File[] Search(string nameToSearch)
        {
            throw new NotImplementedException();
            // код для поиска файлов.
        }
    }
}