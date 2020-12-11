using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.Implementation.DataModels.DataModelsImplementation
{
    public class Playlist<File> : IPlaylist<File>
    {
        /// <summary>
        /// Id of list
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Name of list
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
        /// Method to add file in playlist
        /// </summary>
        /// <param name="file"></param>
        public void Add(File file)
        {
            // код для добавления файла в существующий плэйлист.
        }

        /// <summary>
        /// Method to remove file from playlist
        /// </summary>
        /// <param name="file"></param>
        public void Remove(File file)
        {
            // код для удаления файла из существующего плэйлиста.
        }
        /// <summary>
        /// Method to pick sertain file based on position
        /// </summary>
        /// <param name="filePosition"></param>
        /// <returns></returns>
        public File GetFile(int filePosition)
        {
            throw new NotImplementedException();
            // код для возврата медиафайла.
        }

        /// <summary>
        /// Method to search for files
        /// </summary>
        /// <param name="nameToSearch"></param>
        /// <returns></returns>
        public List<File> Search(string nameToSearch)
        {
            throw new NotImplementedException();
            // код для поиска файлов.
        }
    }
}