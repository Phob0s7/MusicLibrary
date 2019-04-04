using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Audiothèque
{
    abstract class Playlist
    {
        public string name { get; set; }

        public Playlist (string name)
        {
            this.name = name;
        }

        public Music GetMusicAt(int index)
        {
            return 
        }

        public int GetTotalDuration()
        {
            return 
        }

        public int GetMusicCount()
        {
            return 
        }

        abstract protected List<Music> GetMusicList();

		public override string ToString()
		{
			return base.ToString();
		}

	}
