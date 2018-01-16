using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bank = new List<BankAccount>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { " | " },StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }
                var bankName = input[0];
                var acc = input[1];
                var balance = decimal.Parse(input[2]);

                var bankAcc = new BankAccount {
                    Bank = bankName,
                    Name = acc,
                    Balance = balance
                };
                bank.Add(bankAcc);
            }
            var result = bank.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length);

            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1} ({2})",item.Name,item.Balance,item.Bank);
            }
        }
    }
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
}
