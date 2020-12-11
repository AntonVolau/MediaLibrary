using System;
using System.Collections.Generic;
using System.Text;
using MediaLibrary.Implementation.DataModels;
using MediaLibrary.Implementation.Players.MainPlayer;

namespace MediaLibrary.Implementation.Factory
{
    interface IPlayerFactory
    {
        IMediaPlayer Create(IFile file);
    }
}
