using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_) {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
            this.dataUrodzenia = dataUrodzenia_;
        }

        public virtual void WypiszInfo() {
            Console.WriteLine($"Imię: {this.imie}, nazwisko: {this.nazwisko}, data urodzenia: {this.dataUrodzenia}");
        }
    }
}
