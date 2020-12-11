using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;

namespace MediaLibrary.Implementation.Players.MainPlayer
{
    public interface IMediaPlayer
    {
        void Play(File file);

        void Play(Playlist<File> playlist);
    }
}