Feature: Sale Items
	Users want to be able to change the items in the list for sale

Scenario: User wants to see a list of all sale items the system
	Given the user has access to the system
	When the user requests a list of sale items
	Then a list of sale items currently sold is shown

Scenario: User wants to add a new sale item to the list of currently sold items
	Given the user has access to the system
	When the user requests the creation of a new item called "Apple" with a price of £0.50
	Then the sale item is added to the list of items currently sold

Scenario: User wants to edit a sale item in the list of currently sold items
	Given the user has access to the system
	When the user requests an edit of a sale item called "Apple" to have its price changed to £0.55
	Then the sale item is updated in the list of items currently sold

Scenario: User wants to remove a sale item from the list of currently sold items
	Given the user has access to the system
	When the user requests the sale item called "Apple" to be removed from the list of sold items
	Then the sale item is removed from the list of currently sold items