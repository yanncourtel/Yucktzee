# Yucktzee

A yahtzee game in Winforms that needs a "little" refactoring. 
A great refactoring Kata.

# Goal

=> The main goal is to refactor this Yahtzee game and to fix some bugs that are left in the game.
=> Another goal is to add some unit tests and possibly some acceptance tests.

# Instructions

This Kata is meant to be done using TDD for refactoring. This Kata can be done in many different ways. 

First solution : After an "Inside-out" Yahtzee projet.

- You just worked on building the domain part of a Yahtzee game from scratch using TDD with the inside-out method and you want to incorporate that into a user interface. 
 1) Refactor the Winforms solution to be able to add the functions one at a time.
 2) Plug the new domain functions into the user interface.
 3) Add some acceptance tests to verify the total when the game is over (simulate a game from the beginning to the end).


Second solution : Recreate the Yahtzee from scratch with an "outside-in" approach

- You know how your Yahtzee is supposed to behave and therefore, from the user interactions you can know which actions should be done to which objects. 
 1) Refactor the Winforms solution to be able to add the functions one at a time.
 2) Use the "outside-in" approach to make out the entities as you go down the application from the player to the ScoreEngine.
 3) Do this using the TDD double loop with some acceptance tests to verify the total when the game is over (simulate a game from the beginning to the end).

# Go further

Many options can be added to this Kata and it can be extended in various ways. Here are a few examples :

-> Add a multi-player mode (same keyboard, double display in the main form)
-> Add a computer to play against.
-> Add one bonus roll per player and per game to use it at any time.
-> Add the possibility to see a game roll history using the oustide-in TDD approach (with storing the intermediary rolls, etc)
	examle :

	---
	Player 1 (loser) with 141 points
	---
	Roll 1 -- 3, 4, 5, 6, 6
			  4, 6, 1 (6, 6)
			  5, 6 (6, 6, 6)
	=> FourOfAKind = 29 points
	Roll 2 -- 
	...

	---
	Player 2 (winner) with 209 points
	---
	Roll 1 -- 1, 1, 5, 5, 5
	=> FullHouse = 25 points
	Roll 2 -- 1, 2, 5, 4, 4
			  4, 4, 1 (4, 4)
			  4, (4, 4, 4, 4)
	=> Yahtzee = 50 points
	Roll 3 -- 1, 2, 5, 4, 4
			  4, 4, 1 (4, 4)
			  4, (4, 4, 4, 4)
	=> Fours = 20 points
	=> Bonus Yahtzee = +50 points
	...