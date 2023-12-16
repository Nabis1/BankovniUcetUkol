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

        public string Identifikace()
        {
            return $"Identifikace klienta\n Jmeno a Prijmeni : {Jmeno}  {Prijmeni}\n Aktualni zustatek cini: {Zustatek} ";
        }

        public void VlozPenize(double vlozitPenize)
        {
            if (vlozitPenize < 0)
            {
                Console.WriteLine($"Nelze vlozit negativni castku.");
                return;
            }

            Zustatek += vlozitPenize;
            Console.WriteLine($"Vas aktualni zustatek po vlozeni {vlozitPenize} kc je {Zustatek} kc");
            Console.WriteLine("-------------------------------");
        }

        public void VyberPenize(double vybratPenize)
        {
            if (MuzuVybratCastku(vybratPenize))
            {
                Zustatek -= vybratPenize;
                Console.WriteLine($"Váš aktuální zůstatek po výběru {vybratPenize} Kč je {Zustatek} Kč");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("Nemáte dostatek finančních prostředků k vybrání této částky nebo zadaná částka nebyla validní.");
            }
        }

        public bool MuzuVybratCastku(double muzuVybratCastku)
        {
            if (muzuVybratCastku < 0)
            {
                Console.WriteLine("Zadaná částka nemůže být záporná");
                return false;
            }

            if (muzuVybratCastku <= Zustatek)
            {
                Console.WriteLine("Tuto castku muzete vybrat");
                return true;
            }
            Console.WriteLine("Tuto Castku nemuzete vybrat, nemate dostatek financi");
            return false;
        }

        public double VratZustatek()
        {
            Console.WriteLine($"Vas zustatek na uctu je {Zustatek}kc");
            return Zustatek;
        }
       
    }
}
