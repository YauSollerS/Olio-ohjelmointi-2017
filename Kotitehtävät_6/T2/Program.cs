using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia. Muuta/tee toteutus, 
/// jossa CD:n sisällä olevien biisien määrää ei ole rajattu. Käsittele CD:n osalta ainakin seuraavat tiedot: nimi, artisti 
/// ja biisit.
/// Ohjelmoi suunnittelemasi CD-luokka.Toteuta pääohjelmassa CD-olio.Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä.Tulosta ruudulle CD:n tietoja.
/// </summary>
/// 

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
