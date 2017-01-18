using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Tehtävä 5
///Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja 
///toimintoja. Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia 
///opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). Tulosta taulukossa olevien 
///opiskelijoiden tiedot käyttämällä toistorakennetta.
/// </summary>
using JAMK.IT;

namespace T5
{
    class T5
    {
        static void Main(string[] args)
        {


            Opiskelija[] student = new Opiskelija[5];

            for (int i=0; i<5; i++)
            {
                student[i] = new Opiskelija();
            }

            student[0].enimi = "Pekka";
            student[0].snimi = "Nisonen";
            student[0].arvosanaMath = 5;
            student[0].arvosanaPhys = 4;
            student[0].KeskiArvo();

            student[1].enimi = "Jukka";
            student[1].snimi = "Halonen";
            student[1].arvosanaMath = 4;
            student[1].arvosanaPhys = 3;
            student[1].KeskiArvo();

            student[2].enimi = "Mikko";
            student[2].snimi = "Rantalainen";
            student[2].arvosanaMath = 3;
            student[2].arvosanaPhys = 2;
            student[2].KeskiArvo();

            student[3].enimi = "Jarmo";
            student[3].snimi = "Loikanen";
            student[3].arvosanaMath = 2;
            student[3].arvosanaPhys = 1;
            student[3].KeskiArvo();

            student[4].enimi = "Arnold";
            student[4].snimi = "Schwarzenneger";
            student[4].arvosanaMath = 10;
            student[4].arvosanaPhys = 20;
            student[4].KeskiArvo();

            for (int j=0;j<5;j++)
            {
                Console.WriteLine("Opiskelijan {0} etunimi: {1} sukunimi: {2} arvosana: {3}", j, student[j].enimi, student[j].snimi, student[j].keskiar );
            }

                                                           
            
        }
    }
}
