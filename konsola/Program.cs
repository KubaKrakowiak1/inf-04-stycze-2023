class Program
{
    static void Main(string[] args)
    {
        Notatka notatka = new Notatka("Tytuł1", "Treść1");
        Notatka notatka2 = new Notatka("Tytuł2", "Treść2");

        notatka.Wyswietl();
        notatka.Diagnostyczna();
        notatka2.Wyswietl();
        notatka2.Diagnostyczna();
    }
}

class Notatka
{
    private static int Licznik;
    protected int Id;
    protected string Nazwa;
    protected string Tresc;

    public Notatka(string tytul, string tresc)
    {
        Licznik++;
        Id = Licznik;
        this.Tresc = tresc;
        this.Nazwa = tytul;
    }

    public void Wyswietl()
    {
        Console.WriteLine("Tytuł: " + Nazwa);
        Console.WriteLine("Treść: " + Tresc);
    }

    public void Diagnostyczna()
    {
        Console.WriteLine($"nazwa: {Nazwa}; tresc: {Tresc}; licznik: {Licznik}; id: {Id}");
    }
}