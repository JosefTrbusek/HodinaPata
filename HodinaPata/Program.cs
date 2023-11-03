using HodinaPata;

List<Osoba> osoby=new List<Osoba>();

bool jeKonec=false;

while (!jeKonec)
{
    Console.WriteLine("1 - Pridat osobu");
    Console.WriteLine("2 - Smazat osobu");
    Console.WriteLine("3 - Vypsat osoby");
    Console.WriteLine("0 - Konec");

    int volba = Convert.ToInt32(Console.ReadLine());

    switch(volba)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            Osoba osoba = new Osoba();
            Console.WriteLine("Zadej jmeno:");
            osoba.Jmeno = Console.ReadLine();
            Console.WriteLine("Zadej prijmeni: ");
            osoba.Prijmeni = Console.ReadLine();
            Console.WriteLine("Zadej rok narozeni:");
            osoba.RokNarozeni = Console.ReadLine();
            osoby.Add(osoba);
            break;
        case 2:
            Console.WriteLine("Zadej index mazane polozky");
            int index = Convert.ToInt32(Console.ReadLine());
            osoby.RemoveAt(index);
            break;
        case 3:
            int i = 0;
            foreach (Osoba o in osoby)
            {                
                Console.WriteLine($"{i}\t{o.Jmeno}\t{o.Prijmeni}\t{o.RokNarozeni}");
                i++;
            }
            break;
    }
}