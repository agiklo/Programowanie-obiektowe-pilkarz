﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

       

        public string NazwaPrzedmiotu
        {
            get { return nazwaPrzedmiotu; }
            set { nazwaPrzedmiotu = value; }
        }


        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }



        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.wartosc = wartosc;
        }

        public void WypiszInfo() {
            Console.WriteLine($"Nazwa przedmiotu: {this.nazwaPrzedmiotu}, data wystawienia oceny: {this.data}, ocena: {this.wartosc}");
        }
    }
}
