# C# Kata 5: Classes and Inheritance

1. Create an abstract class, Character, with properties Name, Health, and AttackPower.
2. Create an interface, IEvadable, which contains a float property, ChanceToEvade.
3. Create two public classes, Human and Enemy, both of which extend Character. The Enemy class should implement the IEvadable interface.
4. Create a static class named Battlefield. This class should have a public method named StartDuel, which takes two Character objects. This method should randomly select one character to attack the other (in a loop) until one of them has been defeated.
5. In the Program.cs file, instantiate the player and enemy objects and have them fight in the battlefield. (Remember to accommodate the enemy’s ChanceToEvade property!)
6. Print the name of the winner to the console.
7. Bonus Points: Have the program pause for a bit between engagements, printing to the console if the player struck or missed the enemy.
