using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            Console.WriteLine("Account balance:");
            Console.WriteLine(myAccount.GetBalance());


            myAccount.Deposit(25);   /////inaccessible due to protection level (private)

            Console.WriteLine("Deposit amount?");

            var amountToDeposit = double.Parse(Console.ReadLine());

           myAccount.Deposit(amountToDeposit);   /////inaccessible due to protection level (private)
        }
    }
}
