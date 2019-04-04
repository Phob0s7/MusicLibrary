using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Audiothèque
{
    class StandardPlaylist : Playlist
    {
        private List<Music> musicList = new List<Music>();
        private string name;

        public StandardPlaylist (string name) : base(name)
        {
            this.name = name;
        }

        public void AddMusic (Music music)
        {

        }

        public void RemoveMusic (Music music)
        {

        }

        public void ClearList()
        {

        }

        protected override List<Music> GetMusicList()
        {
            return
        }
       


    }
}
