using System;
using System.Collections.Generic;
using System.Text;

namespace Media_library
{
    public class Playlist
    {

        private int Size
        {
            get => default;
            set
            {
                int size;
            }
        }

        private System.Collections.Generic.List<File> Files
        {
            get => default;
            set
            {
                List<File> files;
            }
        }

        private void Sort(File[] files)
        {
            // код для сортировки плэйлиста.
        }

        private void Add(File[] files, File file)
        {
            // код для добавления файла в существующий плэйлист.
        }

        private void Remove(File[] files, File file)
        {
            // код для удаления файла из существующего плэйлиста.
        }

        private File[] Search(File[] files, string nameToSearch)
        {
            throw new NotImplementedException();
            // код для выдачи результатов поиска.
        }
    }
}