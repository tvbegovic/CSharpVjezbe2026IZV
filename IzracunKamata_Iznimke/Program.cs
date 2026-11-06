double IznosKamata(double glavnica, double stopa)
{
    if (glavnica < 0)
        throw new ArgumentOutOfRangeException("Glavnica mora biti >= 0");
    if (stopa < 0 || stopa > 20)
        throw new ArgumentOutOfRangeException("Stopa mora biti 0-20");
    return glavnica * stopa / 100.0;
}
bool nastavi = true;
do
{
    try
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

            Console.Write("Stopa (0-20%): ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }

            double kamata = IznosKamata(glavnica, stopa);
            Console.WriteLine($"Za unesenu glavnicu {glavnica:N2} i kamatnu stopu {stopa}% iznos kamata u jednom obračunskom razdoblju je {kamata:N2}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
    }
}
while (nastavi);

