using System;
/// <summary>
/// Tehtävä 6
///Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla. Tee uusi projekti.
///Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti.
///
/// 
/// PUHELINNUMERON TALLENTAMINEN
/// 
/// </summary>

namespace T6
{
    class Puhelin
    {
        private string enimi;
        private string snimi;
        private string puhnumero;

        public string Enimi
        {
            get { return enimi; }
            set { enimi = value; }
        }

        public string Snimi
        {
            get { return snimi; }
            set { snimi = value; }
        }

        public string Puhnumero
        {
            get { return puhnumero; }
            set { puhnumero = value; }
        }

        public void Kirjoita()
        {
            Console.Write("Lisää etunimi:  ");
            Enimi = Console.ReadLine();
            Console.Write("Lisää sukunimi: ");
            Snimi = Console.ReadLine();
            Console.Write("Lisää puhelinnumero: ");
            Puhnumero = Console.ReadLine();
            Console.WriteLine();

        }

        
        public void Tulosta()
        {
            Console.Write("Etunimi: " + Enimi);
            Console.Write(" Sukunimi: " + Snimi);
            Console.Write(" Puhelinnumero: " + Puhnumero);
            Console.WriteLine();

        }

        
    }
}
