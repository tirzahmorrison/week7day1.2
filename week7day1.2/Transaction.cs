using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7day1._2
{
    class Transaction
    {
        public int ID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
        public int AccountNumber { get; set; }
        public double AmountChanged { get; set; }
        public double NewAmount { get; set; }
    }
}
