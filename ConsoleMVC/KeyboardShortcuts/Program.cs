using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardShortcuts
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class BankAccount
    {
        public int ID { get; set; }
        public double Balance { get; set; }

        public BankAccount(int id, double balance)
        {
            ID = id;
            Balance = balance;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount> Account { get; set; }
        public Person(string name, int age, List<BankAccount> accounts)
        {
            Name = name;
            Age = age;
            Account = accounts;
        }

        public static double GetBalance()
        {
            return GetBalance();    
        }

    }
    
}
