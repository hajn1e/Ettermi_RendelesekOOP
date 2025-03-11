namespace Ettermi_RendelesekOOP;

class Program
{
    static void Main(string[] args)
    {
        Etterem etterem = new Etterem();

        etterem.BeolvasEtelek("etelek.csv");

        Felhasznalo adam = new Felhasznalo("Ádám");
        adam.KosarbaTesz(etterem.Etelek[0]);
        adam.KosarbaTesz(etterem.Etelek[1]);

        Rendeles ujRendeles = adam.Rendel();
        if (ujRendeles != null)
        {
            etterem.UjRendeles(ujRendeles);
        }

        Console.ReadLine();
    }
}