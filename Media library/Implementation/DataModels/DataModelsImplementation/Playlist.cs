using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.Implementation.DataModels.DataModelsImplementation
{
    public class Playlist<File> : IPlaylist<File>
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
        /// Method to sort playlist
        /// </summary>
        public void Sort()
        {
            // код для сортировки плэйлиста.
        }

        /// <summary>
        /// Method for adding a file in playlist
        /// </summary>
        public void Add(File file)
        {
            // код для добавления файла в существующий плэйлист.
        }

        /// <summary>
        /// Method for removing file from playlist
        /// </summary>
        public void Remove(File file)
        {
            // код для удаления файла из существующего плэйлиста.
        }

        public File GetFile(int filePosition)
        {
            throw new NotImplementedException();
            // код для возврата медиафайла.
        }

        /// <summary>
        /// Method to search for files
        /// </summary>
        public List<File> Search(string nameToSearch)
        {
            throw new NotImplementedException();
            // код для поиска файлов.
        }
    }
}