using System;
using System.Collections.Generic;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;
using MediaLibrary.Implementation.Factory.FactoryImplementation;

namespace MediaLibrary
{
    internal class Program
    {
        private static void Main()
        {
            
            Playlist<File> playlist = new Playlist<File>
            {
                // инициализация плэйлиста
            };

            File mediaFile1 = new Photo
            {
                // инициализация фото
            };

            File mediaFile2 = new Music
            {
                // инициализация музыки
            };

            File mediaFile3 = new Video
            {
                // инициализация видео
            };

            // List<File> fileList = new List<File>();
            // fileList.Add(new Photo());

            // Photo
            playlist.Add(mediaFile1); // добавление файла фото в плэйлист
            playlist.Add(new Photo()); // добавление файла фото в плэйлист

            // Music
            playlist.Add(mediaFile2); // добавление файла музыки в плэйлист
            playlist.Add(new Music()); // добавление файла музыки в плэйлист

            // Videos
            playlist.Add(mediaFile3); // добавление файла видео в плэйлист
            playlist.Add(new Video()); // добавление файла видео в плэйлист

            var player = PlayerFactory.Create(playlist.GetFile(0)); // создание необходимого типа плеера в зависимости от типа файла

            player.Play(playlist); // проигрывние плэйлиста
        }
    }
}
