using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee(string nimi, string ammatti, int palkka )
        {
            Name = nimi;
            Profession = ammatti;
            Salary = palkka;
        }

        public override string ToString()
        {
            return " -Nimi: " + Name + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}
