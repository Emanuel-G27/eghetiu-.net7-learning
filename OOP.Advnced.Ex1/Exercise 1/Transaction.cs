using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advnced.Ex1
{
    public class Transaction
    {
        private string type;
        public DateTime Timestamp { get; set; }
        public string Type
        {
            get { return this.type; }
            set {
                if (value == "Deposit" || value == "Withdraw")
                {
                    this.type = value;
                }
                else
                {
                    throw new Exception("Invalid value");
                }
            }

        }
        public double Amount { get; set; }
    }
}
