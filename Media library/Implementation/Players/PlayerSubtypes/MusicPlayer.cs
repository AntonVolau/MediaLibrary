using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.Players.MainPlayer;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;

namespace MediaLibrary.Implementation.Players.PlayerSubtypes
{
    public class MusicPlayer : IMediaPlayer
    {
        public void Play(File file)
        {
            // код для воспроизведения файла музыки.
        }

        public void Play(Playlist<File> playlist)
        {
            // код для воспроизведения плэйлиста музыки.
        }
    }
}
