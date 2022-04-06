using ContaBancariaWithException.Entities.Exceptions;

namespace ContaBancariaWithException.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimite { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimite)
        {
            if (balance == 0)
                throw new DomainException("Error! enter a correct Balance Data");

            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimite = withDrawLimite;
        }

        public void Deposit(double amount)
        {
            Balance =+ amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new DomainException("Not enought balance");

            if (amount > WithDrawLimite)
                throw new DomainException("The amount exceeds withdraw limit!");

            Balance -= amount;

        }

    }
}
