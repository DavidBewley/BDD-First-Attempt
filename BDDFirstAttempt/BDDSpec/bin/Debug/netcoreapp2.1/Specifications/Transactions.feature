Feature: Transacting Items
	Users want to be able to sell items from the list of items for sale in a transaction

Scenario: User wants to create a transaction of items
	Given the user has access to the system
	When the user selects items called "Apple", "Pear" and "Banana" to be sold
	Then the transaction is made and added to the history of transactions
	And The total sale price is returned to the user

Scenario: User wants to see the most recent previous transactions
	Given the user has access to the system
	When the user selects a the most recent transaction
	Then the most recent transaction is returned to the user

Scenario: User wants to see all past transactions
	Given the user has access to the system
	When the user requests to see all the previous transactions made
	Then every previous transaction is returned to the user

Scenario: User wants to see all previous transactions of a specific customer
	Given the user has access to the system
	When the user requests to see all the previous transactions made for customer with an Id of 1
	Then every previous transaction involving the customer is returned to the user