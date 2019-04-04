using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Audiothèque
{
    class IntelligentPlaylist : Playlist
    {
        List<Artist> artistList = new List<Artist>();

        private int lowestRating;
        private MusicLibrary library;

        public IntelligentPlaylist (string name, MusicLibrary library) : base(name)
        {
            this.name = name;
        }

        public void AddArtists (Artist artist)
        {

        }

        public void ClearArtists()
        {

        }

        public void SetLowestRating(int lowestRating)
        {

        }

        public int GetLowestRating()
        {
            return 
        }

        protected override List<Music> GetMusicList()
        {
            return 
        }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
