/*
int käimasolevAasta = 2025;
int olenNiiVana = 560;
int tulemus = käimasolevAasta + olenNiiVana;

//float pikkus = 1.9f;

string sõnum = "Teie vanus on: ";


//bool miskion = false;
// CTRL K C
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
*/

int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
int arv = arv1 + arv2;

Console.WriteLine("Missugust tehet tahad teha? Kirjuta kas: + - / *");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+"  /*tingimus siia*/)
{
    tehe = arv1 + arv2;
}


if (tehtetüüp == "-"  /*tingimus siia*/)
{
    tehe = arv1 - arv2;
}
Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");

if (tehtetüüp == "*"  /*tingimus siia*/)
{
    tehe = arv1 * arv2;
}