using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        

        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            this.rok = rok_;
            this.grupa = grupa_;
            this.nrIndeksu = nrIndeksu_;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Rok studiów: {this.rok}, grupa: {this.grupa}, numer indeksu: {this.nrIndeksu}");
            WypiszOceny();
        }

        #region ListaOcen

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) {
            Ocena ocena = new Ocena(nazwaPrzedmiotu, data, wartosc);
            oceny.Add(ocena);
        }

        public void WypiszOceny() {
            foreach (var ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu) {
            for (int i = 0; i < oceny.Count(); i++)
            {
                if (oceny[i].NazwaPrzedmiotu == nazwaPrzedmiotu) {
                    oceny[i].WypiszInfo();
                }
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count(); i++)
            {
                if (oceny[i].NazwaPrzedmiotu == nazwaPrzedmiotu && oceny[i].Data == data && oceny[i].Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }

        public void UsunOceny()
        {
            oceny.Clear();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count(); i++)
            {
                if (oceny[i].NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }


        #endregion
    }
}
