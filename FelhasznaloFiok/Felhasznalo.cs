using System;
using System.Collections.Generic;
using System.Text;

namespace FelhasznaloFiok
{
    internal class Felhasznalo
    {
        private string jelszo = "123456";
        public string Felhasznalonev { get; set; }
        public void JelszoModositas(string regiJelszo, string ujJelszo)
        {
            if (regiJelszo == jelszo && ujJelszo.Length >= 6)
            {
                jelszo = ujJelszo;
                Console.WriteLine("Jelszó siker módosítva!");
            }
            else
            {
                Console.WriteLine("Helytelen régi jelszó vagy az új jelszó rövidebb 6 karakternél.");
            }


        }
    }
}
