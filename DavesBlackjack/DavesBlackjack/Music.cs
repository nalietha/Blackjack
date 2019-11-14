using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
        public string currentSong { get; private set; }
        private const string songOne = "Lobby Time";
        private const string songTwo = "Bossa Antigua";
        private const string songThree = "Intractable";
        private const string songFour = "Jazz Brunch";
        private const string songFive = "Acid Trumpet";
        /// <summary>
        /// A list of songs used to provide song skipping functionality
        /// </summary>
        private static readonly List<string> songList = new List<string>()
        {
            songOne, songTwo, songThree, songFour, songFive
        };
        private SoundPlayer SoundPlayer = new SoundPlayer();

        public Music()
        {
            isPlaying = false;
        }

        /// <summary>
        /// Starts playing songOne from the songplayer
        /// </summary>
        public void Start()
        {
            currentSong = songOne;
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
            string songPath = "Resources/Music/";
            songPath += currentSong;
            songPath += ".wav";
            SoundPlayer.SoundLocation = songPath;
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