using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class MediaPlayer : IMediaPlayer
    {
        void IMediaPlayer.Play(File file)
        {
            // код для воспроизведения файла.
        }

        void IMediaPlayer.Play(Playlist playlist)
        {
            // код для воспроизведения плэйлиста.
        }
    }
}