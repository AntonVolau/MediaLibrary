using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;

namespace MediaLibrary.Implementation.Players.MainPlayer
{
    public interface IMediaPlayer
    {
        /// <summary>
        /// Method to play one file
        /// </summary>
        void Play(File file);

        /// <summary>
        /// Mthod to play a playlist
        /// </summary>
        void Play(Playlist<File> playlist);
    }
}