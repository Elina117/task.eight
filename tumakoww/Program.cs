using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using tumakoww;

namespace Tumakoww
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 9.1
            BankAccount acc1 = new BankAccount(123, 3000, BankAccount.Acc_Type.Сберегательный);
            BankAccount acc2 = new BankAccount(acc1.new_ID(), 1000, BankAccount.Acc_Type.Накопительный);
            acc2.Transition(acc1, 1000);
            acc2.Dispose();
            acc1.Print();
            acc2.Print();
            // task 9.1
            Song newSong = new Song("n1", "a1");
            Song newSong1 = new Song("n2", "a2", newSong);

            Console.ReadKey();
        }
    }
}
