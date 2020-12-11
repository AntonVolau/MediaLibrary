using MediaLibrary.Implementation.DataModels;
using MediaLibrary.Implementation.DataModels.Enums;
using MediaLibrary.Implementation.Players.MainPlayer;
using MediaLibrary.Implementation.Players.PlayerSubtypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaLibrary.Implementation.Factory.FactoryImplementation
{
    public static class PlayerFactory
    {
        public static IMediaPlayer Create(IFile file)
        {
            if (file.Type is MediaFileTypes.mp4)
            {
                return new VideoPlayer();
            }
            else if (file.Type is MediaFileTypes.mp3)
            {
                return new MusicPlayer();
            }
            else if (file.Type is MediaFileTypes.jpeg)
            {
                return new PhotoPlayer();
            }
            else
            {
                throw new ArgumentException($"{file} have incorrect type");
            }
        }
    }
}
