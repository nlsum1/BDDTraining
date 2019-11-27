using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDTraining.Specs
{
    [Binding]
    public class ATMMachineSteps
    {
        private ATMMachine atmMachine = new ATMMachine();
        private DebitCard debitCard = new DebitCard();

        [Given(@"the account balance is (.*)")]
        public void GivenTheAccountBalanceIs(int balance)
        {
            debitCard.Balance = balance;
        }
        
        [Given(@"the debit card is valid")]
        public void GivenTheDebitCardIsValid()
        {
            debitCard.IsValid = true;
        }
        

        [Given(@"the ATM machine contains enough money with (.*)")]
        public void GivenTheATMMachineContainsEnoughMoneyWith(int money)
        {
            atmMachine.Balance = money;
        }


        [When(@"the Account Holder requests (.*)")]
        public void WhenTheAccountHolderRequests(int money)  
        {
            atmMachine.debitCard = debitCard;
            atmMachine.DispenseMoney(money);
        }
        
        [Then(@"the ATM machine should dispense (.*)")]
        public void ThenTheATMMachineShouldDispense(int amount)
        {
            
        }
        
        [Then(@"the account balance should be (.*)")]
        public void ThenTheAccountBalanceShouldBe(int balance)
        {
            Assert.AreEqual(debitCard.Balance, balance);
        }
        
        [Then(@"the card should be returned")]
        public void ThenTheCardShouldBeReturned()
        {
            //Assert.IsNull(atmMachine.debitCard);
        }


        [Then(@"the ATM machine should not dispense money")]
        public void ThenTheATMMachineShouldNotDispenseMoney()
        {
            
        }


        [Then(@"the account balance should remain (.*)")]
        public void ThenTheAccountBalanceShouldRemain(int balance)
        {
            Assert.AreEqual(debitCard.Balance, balance);
        }

    }
}
