using System;

namespace BankovniUcetUkol;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Your last name: ");
        string lastName = Console.ReadLine();

        User user = new User(firstName, lastName);
        BankAccount acount = new BankAccount(user,15000);
        Console.WriteLine(acount.GetInfo());
        Console.WriteLine("Insert currency");
        double depositMoney = InputValidation.GetDoubleFromConsole();
        acount.DepositMoney(depositMoney);
        Console.WriteLine("Withdraw Currency");
        double withdrawMoney = Convert.ToDouble(Console.ReadLine());
        acount.WithdrawMoney(withdrawMoney);
        Console.WriteLine("Try withdraw random currency");
        double canWithdrawMoney = Convert.ToDouble(Console.ReadLine());
        acount.CanWithdrawMoney(canWithdrawMoney);
        acount.ReturnBalance();
    }

}
