using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {

            CD mutter = new CD("Mutter", "Rammstein");

            Song so1 = new Song("Links 2-3-4", "3:36");
            Song so2 = new Song("Sonne", "4:32");
            Song so3 = new Song("Ich Will", "3:37");
            Song so4 = new Song("Mutter", "4:28");


            mutter.AddSong(so1);
            mutter.AddSong(so2);
            mutter.AddSong(so3);
            mutter.AddSong(so4);

            Console.WriteLine(mutter.ToString());

            Console.WriteLine("-songs:");


            foreach(Song s in mutter.SongsList)
            {
                Console.WriteLine(" - {0}", s.ToString());
            }

        }
    }
}
