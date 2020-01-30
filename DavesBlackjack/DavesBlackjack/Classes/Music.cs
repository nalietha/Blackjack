using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using DavesBlackjack.Properties;

namespace DavesBlackjack
{
    public class Music
    {
        /// <summary>
        /// Determines whether or not music is currently being played
        /// </summary>
        public bool isPlaying { get; private set; }
        /// <summary>
        /// The title of the currently playing song
        /// </summary>
        public System.IO.UnmanagedMemoryStream currentSong { get; private set; }

        /// <summary>
        /// A list of songs used to provide song skipping functionality
        /// </summary>
        private readonly List<System.IO.UnmanagedMemoryStream> songList = new List<System.IO.UnmanagedMemoryStream>()
        {
            Resources.Lobby_Time, Resources.Bossa_Antigua, Resources.Intractable, Resources.Jazz_Brunch, Resources.Acid_Trumpet
        };
        private readonly SoundPlayer SoundPlayer = new SoundPlayer();

        public Music()
        {
            currentSong = songList[0];
            isPlaying = false;
        }

        /// <summary>
        /// Starts playing song one from the songplayer
        /// </summary>
        public void Start()
        {
            currentSong = songList[0];
            Resume();
        }

        /// <summary>
        /// Stops playing music from the songplayer
        /// </summary>
        public void Stop()
        {
            isPlaying = false;
            SoundPlayer.Stop();
        }

        /// <summary>
        /// Resumes playing song from the beginning of the song that was last playing
        /// </summary>
        public void Resume()
        {
            isPlaying = true;
            SoundPlayer.Stream = currentSong;
            SoundPlayer.Stream.Position = 0;
            SoundPlayer.PlayLooping();
        }

        /// <summary>
        /// Skips the song that is currently playing
        /// </summary>
        public void Skip()
        {
            if (isPlaying)
            {
                int index = songList.IndexOf(currentSong);
                index++;
                if (index == 5)
                    index = 0;
                currentSong = songList[index];
                Stop();
                Resume();
            }
        }
    }
}