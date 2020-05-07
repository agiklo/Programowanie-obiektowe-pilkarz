using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) : base(imie_, nazwisko_, dataUrodzenia_)
        {
            this.pozycja = pozycja_;
            this.klub = klub_;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine($"Pozycja: {this.pozycja}, klub: {this.klub}");
        }

        public virtual void StrzelGola() {
            liczbaGoli++;
            Console.WriteLine($"Gooool! Piłkarz ma na swoim koncie {this.liczbaGoli} goli.");

        }
    }

}
