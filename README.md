Scenario: User can initiate a player 
When the user enters their name.
Given that there are two players.
It will allow the user to start the game. 

Scenario: User 1 enters only one of the following: rock, paper, scissors.
When it is their turn. 
Given that the previous user has already entered in their name and that they are valid options of r/p/s. 
It will store their response, and hide it from the second user. 

Scenario: User enters a single letter and it returns a number value. 
Given that the letter is a letter. 
It will return the value. 

Scenario: User enters a multi-letter word.
Given that there are no special characters. 
It will calculate the value of that word and return the value to the user. 

Scenario: User enters a two letter word.
Given that there are no special characters. 
It will calculate the value of that phrase and return the value to the user.