using System;
using System.Collections.Generic;

namespace MediaLibrary
{
    internal class Program
    {
        private static void Main()
        {
            MediaPlayer player = new MediaPlayer
            {
            };

            IPlaylist playlist = new Playlist
            {
            };

            IFile mediaFile1 = new Photo
            {
            };
            IFile mediaFile2 = new Photo
            {
            };

            IFile mediaFile3 = new Music
            {
            };
            IFile mediaFile4 = new Music
            {
            };

            IFile mediaFile5 = new Video
            {
            };
            IFile mediaFile6 = new Video
            {
            };

            // Photo
            playlist.Add(mediaFile1);
            playlist.Add(mediaFile2);

            // Music
            playlist.Add(mediaFile3);
            playlist.Add(mediaFile4);

            // Videos
            playlist.Add(mediaFile5);
            playlist.Add(mediaFile6);

            player.Play(playlist);
        }
    }
}
