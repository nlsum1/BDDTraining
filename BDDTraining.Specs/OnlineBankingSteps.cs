using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace BDDTraining.Specs
{
    [Binding]
    public class OnlineBankingSteps
    {
        private Bank bank = new Bank();
        private BankAccount transfererAccount;
        private BankAccount receiverAccount;
        private int _amount;

        [Given(@"I'm the account owner who wants to transfer money")]
        public void GivenIMTheAccountOwnerWhoWantsToTransferMoney()
        {
            transfererAccount = new BankAccount();
            receiverAccount = new BankAccount();
            transfererAccount.AccountNo = "1234";
            receiverAccount.Balance = 0;
            bank.Result = "";
        }
        
        [Given(@"I have sufficient bank account amount")]
        public void GivenIHaveSufficientBankAccountAmount()
        {
            transfererAccount.Balance = 100000;
          
        }
        
        [Given(@"I'm the account owner who receives money")]
        public void GivenIMTheAccountOwnerWhoReceivesMoney()
        {
            transfererAccount = new BankAccount();
            receiverAccount = new BankAccount();
            transfererAccount.Balance = 100000;
            receiverAccount.Balance = 0;
            receiverAccount.AccountNo = "9999";
            bank.Result = "";
        }
        
        [When(@"I enter (.*) in the amount field")]
        public void WhenIEnterInTheAmountField(int amount)
        {
            _amount = amount;
        }
        
        [When(@"I enter the recipient account number")]
        public void WhenIEnterTheRecipientAccountNumber()
        {
            receiverAccount.AccountNo = "9999";
        }
        
        [When(@"I click transfer button")]
        public void WhenIClickTransferButton()
        {

            bank.Transfer(transfererAccount, receiverAccount, _amount);
        }
        
        [When(@"I check my account balance")]
        public void WhenICheckMyAccountBalance()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"my bank account will be debited (.*)")]
        public void ThenMyBankAccountWillBeDebited(int p0)
        {
            Assert.AreEqual(transfererAccount.ledger.FirstOrDefault().Amount, p0);
            Assert.AreEqual(transfererAccount.ledger.FirstOrDefault().isDebit, true);
        }
        
        [Then(@"my bank account will be credited (.*)")]
        public void ThenMyBankAccountWillBeCredited(int p0)
        {
            Assert.AreEqual(receiverAccount.ledger.FirstOrDefault().Amount, p0);
            Assert.AreEqual(receiverAccount.ledger.FirstOrDefault().isDebit, false);
        }

        [Given(@"person with acount number '(.*)' transfers (.*) to my account")]
        public void GivenPersonWithAcountNumberTransfersToMyAccount(string number, int amount)
        {

            transfererAccount.AccountNo = number;
            bank.Transfer(transfererAccount, receiverAccount, amount);
        }

        [Then(@"I should receive the message from bank ""(.*)""")]
        public void ThenIShouldReceiveTheMessageFromBank(string message)
        {
            Assert.AreEqual(bank.Result, message);
        }



    }
}
