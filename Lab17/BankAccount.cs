using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class BankAccount<T>
    {
        public T Numer;
        public double Summa;
        public string Name;

        public void Enter()
        {
            Console.Write("Введите номер счёта - ");
            Numer =(T) Convert.ChangeType(Console.ReadLine(),typeof(T));
            Console.Write("Введите баланс - ");
            Summa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО - ");
            Name = Console.ReadLine();
        }

        public void Print()
        {
            using (StreamWriter sw = new StreamWriter("BankAccount.txt"))
            {
                sw.WriteLine($"{Numer} - {Summa} - {Name}");
            }
        }
    }
}
