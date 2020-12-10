﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
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
        void Play(Playlist playlist);
    }
}