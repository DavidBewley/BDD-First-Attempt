Feature: Customer Management
	Users want to be able to change the customers saved in the system

Scenario: User wants to see a list of all customers in the system
	Given the user has access to the system
	When the user requests a list of all customers
	Then a list of all current customers is shown

Scenario: User wants to add a new customer to the list of current customers
	Given the user has access to the system
	When the user requests the creation of a new customer called "John" with a price of £0.50
	Then the sale item is added to the list of items currently sold

Scenario: User wants to edit a sale item in the list of currently sold items
	Given the user has access to the system
	When the user requests an edit of a sale item called "Apple" to have its price changed to £0.55
	Then the sale item is updated in the list of items currently sold

Scenario: User wants to remove a customer from the list of current customers
	Given the user has access to the system
	When the user requests the sale item called "Apple" to be removed from the list of sold items
	Then the sale item is removed from the list of currently sold items