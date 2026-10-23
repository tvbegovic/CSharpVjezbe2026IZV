Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Datum 1: ");
string unos = Console.ReadLine();
bool ok = DateTime.TryParse(unos, out DateTime datum1);
if(!ok)
{
    Console.WriteLine("Pogrešan format datuma");
    return;
}
Console.Write("Datum 2: ");
unos = Console.ReadLine();
ok = DateTime.TryParse(unos, out DateTime datum2);
if(!ok)
{
    Console.WriteLine("Pogrešan format datuma");
    return;
}
if (datum1 < datum2)
    Console.WriteLine("Osoba 1 je starija od osobe 2");
else if (datum2 < datum1)
    Console.WriteLine("Osoba 2 je starija od osobe 1");
else
    Console.WriteLine("Osobe su rođene na isti dan");
if (datum1.Month < datum2.Month)
    Console.WriteLine("Osoba 1 slavi rođendan prije osobe 2");
else if (datum1.Month > datum2.Month)
    Console.WriteLine("Osoba 2 slavi rođendan prije osobe 1");
else if (datum1.Day < datum2.Day)
    Console.WriteLine("Osoba 1 slavi rođendan prije osobe 2");
else if (datum1.Day > datum2.Day)
    Console.WriteLine("Osoba 2 slavi rođendan prije osobe 1");
else
    Console.WriteLine("Osobe slave rođendan na isti dan");