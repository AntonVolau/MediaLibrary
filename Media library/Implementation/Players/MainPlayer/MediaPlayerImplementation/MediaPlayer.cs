using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels.DataModelsImplementation;

namespace MediaLibrary.Implementation.Players.MainPlayer.MediaPlayerImplementation
{
    public class MediaPlayer : IMediaPlayer
    {
        public void Play(File file)
        {
            // код для воспроизведения файла.
        }

        public void Play(Playlist<File> playlist)
        {
            // код для воспроизведения плэйлиста.
        }
    }

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

    public class VideoPlayer : IMediaPlayer
    {
        public void Play(File file)
        {
            // код для воспроизведения файла видео.
        }

        public void Play(Playlist<File> playlist)
        {
            // код для воспроизведения плэйлиста видео.
        }
    }

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