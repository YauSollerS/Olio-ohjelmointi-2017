using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Models;

namespace HT
{
    public enum Tuotetyypit
    {
        Hiiret,
        Hiirimatot,
        Kuulokkeet,
        Nappaimistot
    }

    public enum Toimitustavat
    {
        Posti,
        Matkahuolto,
        Kotikuljetus
    }

    public enum Maksutavat
    {
        Visa,
        MasterCard,
        PayPal,
        Kasirahat
    }

}
