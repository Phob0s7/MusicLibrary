using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Audiothèque
{
    class Music
    {
        private string title;
        private int duration;
        private int rating;
        public enum MusicRating
        {
            NO_STAR,
            ONE_STAR,
            TWO_STAR,
            THREE_STAR,
            FOUR_STAR,
            FIVE_STAR
        }

        private List<Artist> composer = new List<Artist>();
        private List<Artist> interpreter = new List<Artist>();

        public void AddInterpret(Artist interpret)
        {

        }

        public void ClearInterpret()
        {

        }

        public void AddCompser(Artist composer)
        {

        }

        public void ClearComposer()
        {

        }
    }
}
