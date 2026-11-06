double IznosKamata(double glavnica, double stopa)
{
    return glavnica * stopa / 100.0;
}
bool nastavi = true;
do
{
    Console.Write("Glavnica: ");
    string unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        bool ok = double.TryParse(unos, out double glavnica);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        if (glavnica < 0)
        {
            Console.WriteLine("Glavnica mora biti pozitivna");
            continue;
        }
        Console.Write("Stopa (0-20%): ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos,out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        if(stopa < 0 || stopa > 20)
        {
            Console.WriteLine("Stopa je izvan raspona");
            continue;
        }
        double kamata = IznosKamata(glavnica, stopa);
        Console.WriteLine($"Za unesenu glavnicu {glavnica:N2} i kamatnu stopu {stopa}% iznos kamata u jednom obračunskom razdoblju je {kamata:N2}");
    }
}
while (nastavi);
