using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDTraining
{
    public class ATMMachine
    {
        public int Balance { get; set; }
        public DebitCard debitCard { get; set; }

        public bool hasCard { get; set; }

        public void DispenseMoney(int withdrawal) {
            if (this.Balance >= withdrawal && debitCard.Balance >= withdrawal)
            {
                this.Balance = this.Balance - withdrawal;
                debitCard.Balance = debitCard.Balance - withdrawal;
            }
            
        }
    }
}
