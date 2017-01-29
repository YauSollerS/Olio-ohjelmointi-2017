using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Song
    {
        public string Name { get; set; }
        public string Lenght { get; set; }
        
        public Song (string nimi, string piitus)
        {
            Name = nimi;
            Lenght = piitus;
        }

        public override string ToString()
        {
            return Name + ", " + Lenght ;
        }
    }

    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }

        private List<Song> songs;

        public List<Song> SongsList
        {
            get { return songs; }
        }
        public CD( string nimi, string laulaja)
        {
            Name = nimi;
            Artist = laulaja;
            songs = new List<Song>();
        }

        public void AddSong(Song track)
        {
            songs.Add(track);
        }

        public override string ToString()
        {
            return "CD data:\n-name: " + Name + "\n-artist: " + Artist;
        }
    }
}
