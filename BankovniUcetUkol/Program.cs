using System;

namespace BankovniUcetUkol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankovniUcet david = new BankovniUcet("David","Pasta",15000);
            Console.WriteLine(david.Identifikace());
            Console.WriteLine("Kolik si prejete vlozit penez?");
            double vlozitPenize = InputValidation.GetDoubleFromConsole();
            david.VlozPenize(vlozitPenize);
            Console.WriteLine("Kolik si přejete vybrat peněz?");
            double vybratPenize = Convert.ToDouble(Console.ReadLine());
            david.VyberPenize(vybratPenize);
            Console.WriteLine("Zkuste vybrat libovolnou castku");
            double muzuVybratCastku = Convert.ToDouble(Console.ReadLine());
            david.MuzuVybratCastku(muzuVybratCastku);
            david.VratZustatek();
        }
    }
}
