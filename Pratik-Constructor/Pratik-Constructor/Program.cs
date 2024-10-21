using OOP;

namespace Pratik_Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  Paramtere almayan Constructor ile nese oluşturma
            Bebek bebek1 = new Bebek();
            bebek1._name = "Orkun";
            bebek1._surname = "Demir";
            Console.WriteLine($"Bebek 1: Ad: {bebek1._name}, Soyad: {bebek1._surname}, Doğum Tarihi: {bebek1._birthday}");

            // Parametre alan Constructor ile nesne oluşturma
            Bebek bebek2 = new Bebek("Umur", "Demir");
            Console.WriteLine($"Bebek 2: Ad: {bebek2._name}, Soyad: {bebek2._surname}, Doğum Tarihi: {bebek2._birthday}");

        }
    }
}
