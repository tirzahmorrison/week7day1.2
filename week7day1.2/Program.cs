using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7day1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new BankContext())
            {
                var today = db.Transactions.Where(t => t.Timestamp > DateTime.Today);
                var recent = db.Transactions.Where(r => r.AccountNumber == 123).Take(10);
                var transaction = new Transaction
                {
                    AccountNumber = 123,
                    Timestamp = DateTime.Now,
                    Action = "Deposit",
                    AmountChanged = 10,
                    NewAmount = 0,
                };
                db.Transactions.Add(transaction);
                db.SaveChanges();
                var userCount = db.Transactions.Where(r => r.AccountNumber == 123 && r.Timestamp > DateTime.Today).Count();
            }
            Console.WriteLine("I am still watching you.");
            Console.ReadLine();
        }
    }
}
