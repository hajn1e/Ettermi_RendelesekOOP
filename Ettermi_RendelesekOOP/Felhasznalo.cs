namespace Ettermi_RendelesekOOP;

internal class Felhasznalo
{
    public string Nev  { get; set; }
    public List<Etel> Kosar  { get; private set; }

    public Felhasznalo(string nev)
    {
        Nev = nev;
        Kosar = new List<Etel>();
    }

    public void KosarbaTesz(Etel etel)
    {
        Kosar.Add(etel);
        Console.WriteLine($"{Nev} kosarába {etel} került!");
    }

    public void KosarMegtekintes()
    {
        Console.WriteLine($"{Nev} kosara:");
        foreach (var etel in Kosar)
        {
            Console.WriteLine(etel);
        }
    }
    

    public Rendeles Rendel()
    {
        if (Kosar.Count == 0)
        {
            Console.WriteLine("A kosár üres!");
            return null;
        }
        var rendeles = new Rendeles(this, new List<Etel>(Kosar));
        Kosar.Clear();
        return rendeles;
    }
    
    
    
    
}