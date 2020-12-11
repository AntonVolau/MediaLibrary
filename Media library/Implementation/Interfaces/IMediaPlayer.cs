using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public interface IMediaPlayer
    {
        /// <summary>
        /// Method to play one file
        /// </summary>
        void Play(IFile file);

        /// <summary>
        /// Mthod to play a playlist
        /// </summary>
        void Play(IPlaylist playlist);
    }
}