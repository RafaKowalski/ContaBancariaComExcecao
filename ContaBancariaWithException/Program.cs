using System;
using ContaBancariaWithException.Entities;
using ContaBancariaWithException.Entities.Exceptions;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data ");
                Console.WriteLine();
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withDrawLimite = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withDrawLimite);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
                Console.WriteLine("new balance: " + account.Balance);
            }
            catch (DomainException de)
            {
                Console.WriteLine("Withdraw error: " + de.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }

}