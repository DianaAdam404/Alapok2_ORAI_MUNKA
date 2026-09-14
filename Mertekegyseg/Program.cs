using Mertekegyseg;
using System.Security.Cryptography;

Atvalto atvalto = new Atvalto();
Console.Write("Kérem a km értéket: ");
atvalto.ertek = double.Parse(Console.ReadLine());
Console.WriteLine($"{atvalto.ertek}km = {atvalto.KmBolMeter(atvalto.ertek)}m.");

Console.Write("Kérem az átváltási szorzót: ");
atvalto.Szorzo = double.Parse(Console.ReadLine());
Console.Write("Kérem az új km értéket: ");
atvalto.ertek = double.Parse(Console.ReadLine());
Console.WriteLine($"{atvalto.ertek}km = {atvalto.EgyediAtvaltas(atvalto.ertek)}m.");
