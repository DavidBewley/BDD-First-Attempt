using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Gherkin.Quick;

namespace BDDSpec.Steps
{
    [FeatureFile("./Specifications/SaleItems.feature")]
    public class SaleItemSteps : Feature
    {
        [Given("the user has access to the system")]
        public void UserHasAccess()
        {

        }

        [When("the user requests a list of sale items")]
        public void UserRequestsListOfItems()
        {

        }

        [When("the user requests the creation of a new item called \"(.*?)\" with a price of £-?[0-9]+(\\.[0-9]+)?")]
        public void UserAddsItem(string item, decimal price)
        {

        }

        [When("the user requests an edit of a sale item called \"(.*?)\" to have its price changed to £-?[0-9]+(\\.[0-9]+)?")]
        public void UserEditsItem(string item, decimal price)
        {

        }

        [When("the user requests the sale item called \"(.*?)\" to be removed from the list of sold items")]
        public void UserDeletesItem(string item)
        {

        }

        [Then("a list of sale items currently sold is shown")]
        public void SaleItemsShown()
        {

        }

        [Then("the sale item is added to the list of items currently sold")]
        public void SaleItemHasBeenAdded()
        {

        }

        [Then("the sale item is updated in the list of items currently sold")]
        public void SaleItemHasBeenEdited()
        {

        }

        [Then("the sale item is removed from the list of currently sold items")]
        public void SaleItemHasBeenDeleted()
        {

        }
    }
}
