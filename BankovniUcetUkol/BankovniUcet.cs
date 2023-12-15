

namespace BankovniUcetUkol
{
    public class BankovniUcet
    {
        public BankovniUcet(string jmeno, string prijmeni, double zustatek)
            
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Zustatek = zustatek;

        }

        public string Jmeno = "David";
        public string Prijmeni = "Pasta";
        public double Zustatek = 0;

        public void Identifikace()
        {
            Console.WriteLine(" Identifikace klienta ");
            Console.WriteLine($" Jmeno a Prijmeni : {Jmeno}  {Prijmeni}");
            Console.WriteLine($" Aktualni zustatek cini: {Zustatek} ");
        }
        public double VlozPenize()
        {
            Console.WriteLine("Kolik si prejete vlozit penez?");
            double vlozitPenize = Convert.ToDouble(Console.ReadLine());
            double zustatekPoVlozeni = vlozitPenize + Zustatek;
            Zustatek += vlozitPenize;
            Console.WriteLine($"Vas aktualni zustatek po vlozeni {vlozitPenize} kc je {zustatekPoVlozeni} kc");
            Console.WriteLine("-------------------------------");
            return zustatekPoVlozeni;
        }
        public double VyberPenize()
        {
            Console.WriteLine("Kolik si přejete vybrat peněz?");
            double vybratPenize = Convert.ToDouble(Console.ReadLine());

            if (vybratPenize >= 0 && Zustatek >= vybratPenize)
            {
                Zustatek -= vybratPenize;
                Console.WriteLine($"Váš aktuální zůstatek po výběru {vybratPenize} Kč je {Zustatek} Kč");
                Console.WriteLine("-------------------------------");
            }
            else if (vybratPenize < 0)
            {
                Console.WriteLine("Zadaná částka nemůže být záporná");
            }
            else
            {
                Console.WriteLine("Nemáte dostatek finančních prostředků k vybrání této částky");
            }

            return Zustatek;
        }
    
        public double MuzuVybratCastku()
        {

            Console.WriteLine("Zkuste vybrat libovolnou castku");
            double muzuVybratCastku = Convert.ToDouble(Console.ReadLine());
            if (muzuVybratCastku < Zustatek)
            {
                Console.WriteLine("Tuto castku muzete vybrat");

            }
            else 
            {
                Console.WriteLine("Tuto Castku nemuzete vybrat, nemate dostatek financi");
            }
            return muzuVybratCastku;
        }
        public void VratZustatek()
        {
            Console.WriteLine($"Vratili jsme vam puvodni zustatek s prvnim vkladem, tzn. {Zustatek}kc");
        }
    }
}
