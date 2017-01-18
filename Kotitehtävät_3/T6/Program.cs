using System;
/// <summary>
/// Tehtävä 6
///Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla. Tee uusi projekti.
///Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti.
/// </summary>

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Puhelin EkaPuhelin = new Puhelin();
            EkaPuhelin.Kirjoita();
            Puhelin ToinenPuhelin = new Puhelin();
            ToinenPuhelin.Kirjoita();
            Puhelin KolmasPuhelin = new Puhelin();
            KolmasPuhelin.Kirjoita();

            EkaPuhelin.Tulosta();
            ToinenPuhelin.Tulosta();
            KolmasPuhelin.Tulosta();
           
        }
    }
}
