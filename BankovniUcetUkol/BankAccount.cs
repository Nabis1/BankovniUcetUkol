namespace BankovniUcetUkol
{
    public class BankAccount
    {
        public User User { get; private set; }

        public double Balance { get; private set; }

        public BankAccount(User user, double balance)
        {
            Balance = balance;
            User = user;
        }
        public string GetInfo()
        {
            return $"{User.GetInfo()} Balance: {Balance}\n";
        }

        public void DepositMoney(double depositMoney)
        {
            if (depositMoney < 0)
            {
                Console.WriteLine($"You cannot enter a negative amount.");
                return;
            }

            Balance += depositMoney;
            Console.WriteLine($"Your current balance after deposit {depositMoney} kc is {Balance} kc");
            Console.WriteLine("-------------------------------");
        }

        public void WithdrawMoney(double withdrawMoney)
        {
            if (CanWithdrawMoney(withdrawMoney))
            {
                Balance -= withdrawMoney;
                Console.WriteLine($"Your current balance after withdrawal {withdrawMoney} Kč is {Balance} Kč");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("You do not have enough funds to withdraw this amount or the amount entered was not valid.");
            }
        }

        public bool CanWithdrawMoney(double canWithdrawMoney)
        {
            if (canWithdrawMoney < 0)
            {
                Console.WriteLine("The entered amount cannot be negative");
                return false;
            }

            if (canWithdrawMoney <= Balance)
            {
                Console.WriteLine("You can select this amount");
                return true;
            }
            Console.WriteLine("You cannot withdraw this amount, you do not have enough funds");
            return false;
        }

        public double ReturnBalance()
        {
            Console.WriteLine($"Balance on your account is {Balance}kc");
            return Balance;
        }
       
    }
}
