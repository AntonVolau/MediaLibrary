using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;

namespace MediaLibrary.Implementation.Players.MainPlayer.MediaPlayerImplementation
{
    public class MediaPlayer : IMediaPlayer
    {
        /// <summary>
        /// method for playback of single file
        /// </summary>
        /// <param name="file"></param>
        public void Play(File file)
        {
            // код для воспроизведения файла.
        }

        /// <summary>
        /// method for playback of playlist
        /// </summary>
        /// <param name="playlist"></param>
        public void Play(Playlist<File> playlist)
        {
            // код для воспроизведения плэйлиста.
        }
    }
}