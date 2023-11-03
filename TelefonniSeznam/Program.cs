var telefonniSeznam = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
Dictionary<string, string> t2 = new();
bool jeKonec = false;
while(!jeKonec)
{
    Console.WriteLine("1 - Pridat osobu");
    Console.WriteLine("2 - Smazat osobu");
    Console.WriteLine("3 - Vypsat osoby");
    Console.WriteLine("4 - Vyhledej podle cisla");
    Console.WriteLine("0 - Konec");

    int volba = Convert.ToInt32(Console.ReadLine());

    switch(volba)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            {
                Console.WriteLine("Zadej jmeno:");
                string jmeno = Console.ReadLine();
                if (telefonniSeznam.ContainsKey(jmeno))
                {
                    Console.WriteLine("Toto jmeno uz v seznamu existuje");
                }
                else
                {
                    Console.WriteLine("Zadej telefonni cislo:");
                    string cislo = Console.ReadLine();
                    telefonniSeznam.Add(jmeno, cislo);
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("Zadej jmeno");
                string jmeno = Console.ReadLine();
                //if(telefonniSeznam.ContainsKey(jmeno))
                //{
                //    telefonniSeznam.Remove(jmeno);
                //    Console.WriteLine("Polozka uspesne smazana.");
                //}
                //else
                //{
                //    Console.WriteLine("Polozka neexistuje.");
                //}
                if(telefonniSeznam.Remove(jmeno))
                {
                    Console.WriteLine("Polozka uspesne smazana.");
                }
                else
                {
                    Console.WriteLine("Polozka neexistuje.");
                }
                break;
            }
        case 3:
            foreach (var kontakt in telefonniSeznam)
            {
                Console.WriteLine($"{kontakt.Key}\t{kontakt.Value}");

            }
            break;
        case 4:
            Console.WriteLine("Zadej pocatek cisla:");
            string pocatek=Console.ReadLine();
            var jmena = telefonniSeznam.Where(x => x.Value.StartsWith(pocatek)).Select(z => z.Key).ToList();
            var found = jmena.Find(x => x.StartsWith("K"));
            foreach(var jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }
            break;
    }
}