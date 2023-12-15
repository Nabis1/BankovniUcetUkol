namespace BankovniUcetUkol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte pocatecni castku na vasem uctu");
            BankovniUcet david = new BankovniUcet("David","Pasta", Convert.ToDouble(Console.ReadLine()));
            david.Identifikace();
            david.VlozPenize();
            david.VyberPenize();
            david.MuzuVybratCastku();
            david.VratZustatek();
        }
    }
}
