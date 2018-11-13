using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Gherkin.Quick;
using TillApi.Models;
using TillApi.DataAccessLayer.Interfaces;
using TillApi.DataAccessLayer.Production;
using Moq;
using FluentAssertions;
using System.Linq;

namespace BDDSpec.Steps
{
    [FeatureFile("./Specifications/CustomerManagement.feature")]
    public class CustomerManagementSteps : Feature
    {
        #region DummyData
        Customer customerOne = new Customer();
        #endregion

        ICustomerRepo customerRepo;
        List<Customer> customerList;
        Customer singleCustomer;
        int customerId;

        [Given("the user has access to the system")]
        public void UserHasAccess()
        {
            customerRepo = new CustomerRepo();
        }

        [When("the user requests a list of all customers")]
        public void UserRequestsAllCustomers()
        {
            var moq = new Mock<ICustomerRepo>();
            moq.Setup(o => o.GetAllCustomers()).Returns(new List<Customer>() { customerOne });
            customerRepo = moq.Object;

            customerList = customerRepo.GetAllCustomers();
        }

        [When(@"the user requests to see the details of the customer with Id (-?\d+)")]
        public void UserRequestsOneCustomer(int id)
        {

        }

        [When("the user requests the creation of a new customer with the following details FirstName:\"(.*?)\" Surname:\"(.*?)\" EmailAddress:\"(.*?)\"")]
        public void UserRequestsNewCustomer(string forename, string surname, string email)
        {

        }

        [When("the user requests an edit of a customer with the Id (-?\\d+) to the following details FirstName:\"(.*?)\" Surname:\"(.*?)\" EmailAddress:\"(.*?)\"")]
        public void UserRequestsUpdateToCustomer(int id, string forename, string surname, string email)
        {

        }

        [When(@"the user requests the customer with Id (-?\d+) is removed from the active customers list")]
        public void UserRequestsDeletionOfCustomer(int id)
        {
            int newid = id;
        }

        [Then("a list of all current customers is shown")]
        public void ListAllCurrentCustomers()
        {
            customerList.Count().Should().Be(1);
        }

        [Then(@"the user with Id (-?\d+) is returned")]
        public void ShowSingleCustomerFromId(int id)
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

        [Then(@"the customer with Id (-?\d+) is removed from the active customer list")]
        public void RemovedCustomerNotInCustomerList(int id)
        {

        }
    }
}
