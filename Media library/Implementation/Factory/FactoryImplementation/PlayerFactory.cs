using MediaLibrary.Implementation.DataModels;
using MediaLibrary.Implementation.DataModels.Enums;
using MediaLibrary.Implementation.Players.MainPlayer;
using MediaLibrary.Implementation.Players.PlayerSubtypes;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.Implementation.Factory.FactoryImplementation
{
    public static class PlayerFactory
    {

        public static IMediaPlayer Create(IFile file) // метод для выбора необходимого типа плеера.
        {
            if (file.Type is MediaFileTypes.mp4)
            {
                return new VideoPlayer(); // выбираем плеер для воспроизведения видео.
            }
            else if (file is Music)
            {
                return new MusicPlayer(); // выбираем плеер для воспроизведения музыки.
            }
            else if (file.Type is MediaFileTypes.jpeg)
            {
                return new PhotoPlayer(); // выбираем плеер для воспроизведения фото.
            }
            else
            {
                throw new ArgumentException($"{file} have incorrect type"); // вбрасываем исключение, если тип файла не соответствует допустимому.
            }
        }
    }
}
