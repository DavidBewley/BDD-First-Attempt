Feature: Customer Management
	Users want to be able to change the customers saved in the system

Scenario: User wants to see a list of all customers in the system
	Given the user has access to the system
	When the user requests a list of all customers
	Then a list of all current customers is shown

Scenario: User wants to see the details of a single customer
	Given the user has access to the system
	When the user requests to see the details of the customer with Id 1
	Then the user with Id 1 is returned

Scenario: User wants to add a new customer to the list of current customers
	Given the user has access to the system
	When the user requests the creation of a new customer with the following details FirstName:"Reginald" Surname:"Bumblewart" EmailAddress:"Reginald.Bumblewart@email.co.uk"
	Then the customer is added to the list of current customers

Scenario: User wants to edit a current customers details
	Given the user has access to the system
	When the user requests an edit of a customer with the Id 1 to the following details FirstName:"Franny" Surname:"Mcjeofferson" EmailAddress:"Franny.Mcjeofferson@email.co.uk"
	Then the customer is updated in the list of current customers

Scenario: User wants to remove a customer from the list of current customers
	Given the user has access to the system
	When the user requests the customer with Id 1 is removed from the active customers list
	Then the customer with Id 1 is removed from the active customer list