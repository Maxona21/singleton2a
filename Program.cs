// See https://aka.ms/new-console-template for more information

using singleton2a;
class Program
{
    static void Main()
    {
        Drukarka drukarka1 = Drukarka.PobierzInstancje();
        Drukarka drukarka2 = Drukarka.PobierzInstancje();

        drukarka1.Drukuj("Raport miesieczny");
        drukarka2.Drukuj("Faktura VAT");

        Console.WriteLine(ReferenceEquals(drukarka1, drukarka2));
    }
}
