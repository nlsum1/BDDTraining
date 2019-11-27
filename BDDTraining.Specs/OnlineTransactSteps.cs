using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDTraining.Specs
{
    [Binding]
    public class OnlineTransactSteps
    {
        private Registration registration = new Registration();
        private IList<IAccount> accountList = new List<IAccount>();
        private Mock<IAccount> account = new Mock<IAccount>();

        [Given(@"I am a valid account holder")]
        public void GivenIAmAValidAccountHolder()
        {
            account.Setup(x => x.IsValid()).Returns(true);
        }
        
        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            registration = table.CreateInstance<Registration>();
            registration.account = account.Object;
            
        }
        
        [When(@"I register")]
        public void WhenIRegister()
        {
            registration.Register();
        }
        
        [Then(@"I should receive the message ""(.*)""")]
        public void ThenIShouldReceiveTheMessage(string result)
        {
            registration.Result = result;
        }

        [Given(@"there are several valid account holders")]
        public void GivenThereAreSeveralValidAccountHolders(Table table)
        {
            accountList = table.CreateSet<IAccount>().ToList();

        }

    }
}
