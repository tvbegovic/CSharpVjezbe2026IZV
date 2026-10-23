Console.Write("Unesite redni broj mjeseca (1-12): ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int redniBrojMjeseca);
if(!ok)
{
    Console.WriteLine("Broj je u pogrešnom formatu");
    return;
}
if(redniBrojMjeseca < 1 || redniBrojMjeseca > 12)
{
    Console.WriteLine("Broj je izvan raspona");
    return;
}
int brojDana;
string sufix = "a";
switch (redniBrojMjeseca)
{
    case 2:
        if (DateTime.IsLeapYear(DateTime.Now.Year))
            brojDana = 29;
        else
            brojDana = 28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        brojDana = 30;
        break;
    default:
        brojDana = 31;
        sufix = "";
        break;
}
Console.WriteLine($"{redniBrojMjeseca}. mjesec ima {brojDana} dan{sufix}");