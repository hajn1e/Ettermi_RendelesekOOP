namespace Ettermi_RendelesekOOP;

internal class Rendeles
{
    public Felhasznalo Megrendelo { get; set; }
    public List<Etel> Termekek { get; set; }
    public string Allapot { get; set; }
    
    public Rendeles(Felhasznalo megrendelo, List<Etel> termekek)
    {
        Megrendelo = megrendelo;
        Termekek = termekek;
        Allapot = "Feldolgozás alatt";
        
    }
    
    public void AllapotFrissites(string ujallapot)
    {
        Allapot = ujallapot;
        Console.WriteLine($"Rendelés állpotának frissítve: {ujallapot}");
    }

    public override string ToString()
    {
        return $"Megrendelo: {Megrendelo.Nev}" +
                $"Allapot: {Allapot}"
                + $"Termékek: {Termekek}";
                
    }
}

