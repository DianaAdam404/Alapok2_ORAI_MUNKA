using Raktarkezelo;
RaktarElem elem = new RaktarElem { CikkNev = "Iphone" };
Console.WriteLine($"--{elem.CikkNev} raktárkezelése--");
Console.Write("Kérem a bevételezett mennyiséget: ");
elem.db = int.Parse(Console.ReadLine());
elem.Bevetelezes(elem.db);

Console.Write("Kérem a kiadott mennyiséget: ");
elem.db = int.Parse(Console.ReadLine());
elem.Kiadas(elem.db);

double nettoAr = 15000;
double brutto = RaktarElem.BruttoArSzamitas(nettoAr);
Console.WriteLine($"Nettó ár: {nettoAr}Ft = Bruttó ár: {brutto}Ft");
