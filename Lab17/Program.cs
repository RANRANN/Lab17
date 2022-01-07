using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankaccount1 = new BankAccount<int>();
            bankaccount1.Enter();
            bankaccount1.Print();
            Console.ReadKey();

            BankAccount<string> bankaccount2 = new BankAccount<string>();
            bankaccount2.Enter();
            bankaccount2.Print();
            Console.ReadKey();
        }
    }
}
