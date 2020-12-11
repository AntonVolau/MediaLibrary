using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary
{
    public class MediaPlayer : IMediaPlayer
    {
        public void Play(IFile file)
        {
            // код для воспроизведения файла.
        }

        public void Play(IPlaylist playlist)
        {
            // код для воспроизведения плэйлиста.
        }
    }
}