using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Gherkin.Quick;

namespace BDDSpec.Steps
{
    [FeatureFile("./Specifications/CustomerManagement.feature")]
    public class CustomerManagementSteps : Feature
    {
        [Given("the user has access to the system")]
        public void UserHasAccess()
        {

        }

        [When("the user requests a list of all customers")]
        public void UserRequestsAllCustomers()
        {

        }

        [When("the user requests to see the details of the customer with Id 1")]
        public void UserRequestsOneCustomer()
        {

        }

        [When("the user requests the creation of a new customer with the following details FirstName:\"John\" Surname: \"Smith\" EmailAddress\"John.Smith@email.co.uk\"")]
        public void UserRequestsNewCustomer()
        {

        }

        [When("the user requests an edit of a customer with the Id 1 to the following details FirstName:\"Jane\" Surname: \"Smith\" EmailAddress\"Jane.Smith@email.co.uk\"")]
        public void UserRequestsUpdateToCustomer()
        {

        }

        [When("the user requests the customer with Id 1 is removed from the active customers list")]
        public void UserRequestsDeletionOfCustomer()
        {

        }

        [Then("a list of all current customers is shown")]
        public void ListAllCurrentCustomers()
        {

        }

        [Then("the user with Id 1 is returned")]
        public void ShowSingleCustomerFromId()
        {

        }

        [Then("the customer is added to the list of current customers")]
        public void NewCustomerAddedToCurrentCustomersList()
        {

        }

        [Then("the customer is updated in the list of current customers")]
        public void UpdatedCustomerDataCorrectInCustomerList()
        {

        }

        [Then("the customer with Id 1 is removed from the active customer list")]
        public void RemovedCustomerNotInCustomerList()
        {

        }
    }
}
