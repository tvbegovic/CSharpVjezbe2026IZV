Console.Write("Ime: ");
string ime = Console.ReadLine();
Console.Write("Prezime: ");
string prezime = Console.ReadLine();
Console.WriteLine($"Vaši inicijali su {ime.Substring(0,1)}.{prezime.Substring(0, 1)}.");