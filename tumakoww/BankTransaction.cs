using System;
namespace tumakoww
{
    public class BankTransaction
    {
        readonly DateTime data = DateTime.Now;
        readonly decimal summa;

        public BankTransaction(decimal summa)
        {
            this.summa = summa;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Date:{data} Sum:{summa}");
        }
    }
}

