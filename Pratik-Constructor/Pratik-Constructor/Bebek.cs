namespace OOP;
class Bebek
{
    public DateTime _birthday;
    public string _name;
    public string _surname;

    public Bebek()
    {
        _birthday = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    // Parametre alan Constructor
    public Bebek(string name, string surname)
    {
        _name = name;
        _surname = surname;
        _birthday = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }
}

