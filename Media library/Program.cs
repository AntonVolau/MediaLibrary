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
            Playlist<File> playlist = new Playlist<File>();

            File mediaFile1 = new Photo
            {
                // инициализация файла фото
            };

            File mediaFile2 = new Music
            {
                // инициализация файла музыки
            };

            File mediaFile3 = new Video
            {
                // инициализация файла видео
            };

            // Photo
            playlist.Add(mediaFile1); // добавление инициализированного файла фото в плэйлист
            playlist.Add(new Photo()); // добавление файла фото в плэйлист с инициализацией в аргументе

            // Music
            playlist.Add(mediaFile2); // добавление инициализированного файла музыки в плэйлист
            playlist.Add(new Music()); // добавление файла музыки в плэйлист с инициализацией в аргументе

            // Videos
            playlist.Add(mediaFile3); // добавление инициализированного файла видео в плэйлист
            playlist.Add(new Video()); // добавление файла видео в плэйлист с инициализацией в аргументе

            for (int i = 0; i < playlist.Size; i++)
            {
                var player = PlayerFactory.Create(playlist.GetFile(i)); // создание необходимого типа плеера в зависимости от типа файла в плэйлисте
                player.Play(playlist); // проигрывние плэйлиста
            }

            var player1 = PlayerFactory.Create(playlist.GetFile(2)); // создание необходимого типа плеера в зависимости от типа файла

            player1.Play(mediaFile2); // проигрывние файла
        }
    }
}
