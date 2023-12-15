
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace BankovniUcetUkol
{
    public class BankovniUcet
    {
        public BankovniUcet(string jmeno, string prijmeni, double zustatek)
            
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Zustatek = zustatek;
            //ZustatekPoVlozeni = 0; //zustatekPoVlozeni;
            //ZustatekPoVybrani = 0; //zustatekPoVybrani;

        }

        public string Jmeno = "David";
        public string Prijmeni = "Pasta";
        public double Zustatek = 0;
        //public double ZustatekPoVlozeni = 0;
        //public double ZustatekPoVybrani = 0;

        public void Identifikace()
        {
            Console.WriteLine(" Identifikace klienta ");
            Console.WriteLine($" Jmeno a Prijmeni : {Jmeno}  {Prijmeni}");
            Console.WriteLine($" Aktualni zustatek cini: {Zustatek} ");
        }
        public double VlozPenize()
        {
            Console.WriteLine("Kolik si prejete vlozit penez?");
            double vlozitpenize = Convert.ToDouble(Console.ReadLine());
            double zustatekPoVlozeni = vlozitpenize + Zustatek;
            Console.WriteLine($"Vas aktualni zustatek po vlozeni {vlozitpenize} kc je {zustatekPoVlozeni} kc");
            Console.WriteLine("-------------------------------");
            return zustatekPoVlozeni;
        }
        public double VyberPenize()
        {
            Console.WriteLine("Kolik si prejete vybrat penez?");
            double vybratpenize = Convert.ToDouble(Console.ReadLine());
            double novyzustatek1 = Zustatek - vybratpenize;
            Console.WriteLine($"Vas aktualni zustatek po vybrani {vybratpenize} kc je {novyzustatek1} kc");
            Console.WriteLine("-------------------------------");
            return novyzustatek1;
        }
        public double MuzuVybratCastku()
        {

            Console.WriteLine("Zkuste vybrat libovolnou castku");
            double muzuVybratCastku = Convert.ToDouble(Console.ReadLine());
            if (Zustatek < muzuVybratCastku)
            {
                Console.WriteLine("Tuto Castku nemuzete vybrat, nemate dostatek financi");

            }
            else if (Zustatek > muzuVybratCastku)
            {
                Console.WriteLine("Tuto castku muzete vybrat");
            }
            return muzuVybratCastku;
        }
        public void VratZustatek()
        {
            Console.WriteLine($"Vratili jsme vam puvodni zustatek, ktery jste zadal na zacatku, cini {Zustatek}kc");
        }
    }
}
