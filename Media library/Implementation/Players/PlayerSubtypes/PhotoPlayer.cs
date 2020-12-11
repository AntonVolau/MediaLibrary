﻿using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.Players.MainPlayer;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;

namespace MediaLibrary.Implementation.Players.PlayerSubtypes
{
    public class PhotoPlayer : IMediaPlayer
    {
        public void Play(File file)
        {
            // код для воспроизведения файла фото.
        }

        public void Play(Playlist<File> playlist)
        {
            // код для воспроизведения плэйлиста фотографий.
        }
    }
}
