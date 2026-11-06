void IzracunParametara(double iznos, double stopa, int brojGodina, out double anuitet, out double iznosKamata)
{
    if (iznos < 0)
        throw new ArgumentOutOfRangeException("Iznos mora biti >= 0");
    if (stopa < 2 || stopa > 15)
        throw new ArgumentOutOfRangeException("Stopa mora biti 2-15");
    if (brojGodina < 3 || brojGodina > 30)
        throw new ArgumentOutOfRangeException("Broj godina mora biti 3-30");
    double r = Kamatnjak(stopa);
    int n = brojGodina * 12;
    anuitet = iznos * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
    iznosKamata = anuitet * n - iznos;
}

double Kamatnjak(double stopa)
{
    return 1 + stopa / 100 / 12;
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
            Console.Write("Stopa (2-15%): ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Broj godina (3-30): ");
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out int brojGodina);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            IzracunParametara(glavnica, stopa, brojGodina, out double anuitet, out double ukupnoKamata);
            Console.WriteLine($"„Za zadani iznos kredita {glavnica:N2}, godišnju kamatnu stopu {stopa} i broj godina otplate {brojGodina} anuitet je {anuitet:N2} a ukupno plaćena kamata {ukupnoKamata:N2}");

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
    }
}
while (nastavi);