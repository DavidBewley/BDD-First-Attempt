using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Gherkin.Quick;

namespace BDDSpec.Steps
{
    [FeatureFile("./Specifications/Transactions.feature")]
    public class TransactionSteps : Feature
    {
        [Given("the user has access to the system")]
        public void UserHasAccess()
        {

        }

        [When("the user selects items called \"(.*?)\", \"(.*?)\" and \"(.*?)\" to be sold")]
        public void UserCreatesTransaction(string itemOne, string itemTwo, string ItemThree)
        {
            
        }

        [When("the user selects a the most recent transaction")]
        public void UserRequestsMostPreviousTransaction()
        {

        }

        [When("the user requests to see all the previous transactions made")]
        public void UserRequestsAllPreviousTransactions()
        {

        }

        [When(@"the user requests to see all the previous transactions made for customer with an Id of (-?\d+)")]
        public void UserRequestsSpecifcPreviousTransaction()
        {

        }

        [Then("the transaction is made and added to the history of transactions")]
        public void TransactionCreated()
        {

        }

        [And("The total sale price is returned to the user")]
        public void SalePriceReturned()
        {

        }

        [Then("the most recent transaction is returned to the user")]
        public void MostRecentTransactionReturned()
        {

        }

        [Then("every previous transaction is returned to the user")]
        public void AllTransactionsReturned()
        {

        }

        [Then("every previous transaction involving the customer is returned to the user")]
        public void AllTransactionsInvolvingSpecificCustomerReturned()
        {

        }
    }
}
