using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDTraining
{


    public class Bank
    {
        public string Result { get; set; }
        public void Transfer(BankAccount transferer, BankAccount receiver, int amount)
        {
            var creditLegder = new Ledger();
            var debitLedger = new Ledger();
            creditLegder.Amount = amount;
            creditLegder.isDebit = false;
            debitLedger.Amount = amount;
            debitLedger.isDebit = true;

            transferer.ledger.Add(debitLedger);
            receiver.ledger.Add(creditLegder);

            transferer.Balance -= amount;
            receiver.Balance += amount;

            this.Result = "Transferred successfully";

        }
    }

    public class BankAccount
    {
        public BankAccount(){
            ledger = new List<Ledger>();
        }
        public string AccountNo { get; set; }
        public int Balance { get; set; }
        public IList<Ledger> ledger {get; set;}
    }

    public class Ledger
    {
      public int Amount { get; set; }
      public bool isDebit { get; set; }

    }
}
