using WebaruhazTermek;
Termek termek1 = new Termek { Nev = "Laptop", Egysegar = 250000, Keszlet = 10 };
Termek termek2 = new Termek { Nev = "Gep", Egysegar = -500, Keszlet = -5 };

Console.WriteLine($"{termek1.Nev} Ár: {termek1.Egysegar} Ft, Készlet: {termek1.Keszlet} db.");
Console.WriteLine($"{termek2.Nev} Ár: {termek2.Egysegar} Ft, Készlet: {termek2.Keszlet} db.");