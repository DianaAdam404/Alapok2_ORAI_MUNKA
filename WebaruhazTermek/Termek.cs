using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WebaruhazTermek
{
    internal class Termek
    {
        public string Nev { get; set; }
        private int egysegar;
        public int Egysegar
        {
            get { return egysegar; }
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Az egységár nem lehet kisebb, mint 1.");
                    egysegar = 1;
                }
                else egysegar = value;
            }
        }

        private int keszlet;
        public int Keszlet
        {
            get { return keszlet; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("A készlet nem lehet negatív.");
                    keszlet = 0;
                }
                else keszlet = value;
            }
        }
    }

}
}
