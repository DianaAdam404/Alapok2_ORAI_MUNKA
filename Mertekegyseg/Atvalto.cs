using System;
using System.Collections.Generic;
using System.Text;

namespace Mertekegyseg
{
    internal class Atvalto
    {
        public double ertek;
        public double KmBolMeter(double ertek)
        {
            return ertek * 1000;
        }
        public double Szorzo;
        public double EgyediAtvaltas(double ertek)
        {
            return ertek * Szorzo;
        }
    }
}
