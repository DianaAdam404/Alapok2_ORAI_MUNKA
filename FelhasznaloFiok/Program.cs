using FelhasznaloFiok;
Felhasznalo hasznalo = new Felhasznalo { Felhasznalonev = "test" };
//hasznalo.jelszo = "nemmukodik";
//       ^^^jelszo privalt^^^

Console.WriteLine("Hibás régi jelszó teszt");
hasznalo.JelszoModositas("rossz123", "ujJelszo123");

Console.WriteLine("Tul rövid uj jelszó test");
hasznalo.JelszoModositas("123456", "123");

Console.WriteLine("Helyes módosítás test ---");
hasznalo.JelszoModositas("123456", "ujJelszo123");