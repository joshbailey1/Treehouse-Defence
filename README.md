# Treehouse-Defence
This is a tower defence game I programmed with the online learning website treehouse academy.
The course taught me how to use object oriented programming in C# and went over the principles of OOP (Encapsulation, Abstraction, Inheritance and Polymorphism) during the coding of this game.
At the end of the course the game wasn't interactive at all. You created a map, a path (for the invaders to move along, at the end of which is the base you're defending), some invaders, and some towers. All of this was created in code then you ran the program to see if you neutralized all the invaders and won the game, or an invader made it to the end of the path and you lost the game.
I coded a DisplayMap method for the Map class so that the user can see the map and the path. To do this I created a method for the Path class called OnPath so that I could differentiate between an empty space in the map (one you could place towers on) and the path. 
Then in the Game class I displayed the map, then asked for user input so that they can decide where to put the towers.
Now the program runs, shows you the map with the path, you decide where to put your 3 towers, and then the game runs as before to see if you win or lose.

I would like to add more to this game in the future. I would like to have multiple levels with either preset paths, or randomly generated paths.
