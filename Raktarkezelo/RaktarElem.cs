using System;
using System.Collections.Generic;
using System.Text;

namespace Raktarkezelo
{
    internal class RaktarElem
    {
        private int dbSzam;
        public string CikkNev { get; set; }
        public static double AfaKulcs { get; set; } = 0.27;
        public int db;
        public void Bevetelezes(int db)
        {
            if (db <= 0)
            {
                Console.WriteLine("Figyelmeztetés: A bevételezett mennyiségnek 0-nál nagyobbnak kell lennie!");
                return;
            }
            dbSzam += db;
            Console.WriteLine($"Bevételezve: {db} db. Jelenlegi készlet: {dbSzam} db.");
        }
        public void Kiadas(int db)
        {
            if (db <= 0)
            {
                Console.WriteLine("Figyelmeztetés: A kiadott mennyiségnek 0-nál nagyobbnak kell lennie!");
                return;
            }
            if (db > dbSzam)
            {
                Console.WriteLine("Figyelmeztetés: Nincs ennyi készlet!");
                return;
            }
            dbSzam -= db;
            Console.WriteLine($"Kiadva: {db} db. Jelenlegi készlet: {dbSzam} db.");
        }
        public static double BruttoArSzamitas(double nettoAr)
        {
            return nettoAr * (1 + AfaKulcs);
        }
    }
}
