using System;

namespace BankovniUcetUkol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankovniUcet david = new BankovniUcet("David","Pasta",15000);
            david.Identifikace();
            david.VlozPenize();
            david.VyberPenize();
            david.MuzuVybratCastku();
            david.VratZustatek();
        }
    }
}
