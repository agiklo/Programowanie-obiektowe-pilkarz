using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) : base(imie_, nazwisko_, dataUrodzenia_, pozycja_, klub_)
        {

        }
        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Nożny strzelił!");
        }
    }
}
