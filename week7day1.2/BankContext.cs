using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace week7day1._2
{
    class BankContext: DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
    }
}
