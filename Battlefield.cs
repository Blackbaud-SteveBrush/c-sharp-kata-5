using System;

namespace Kata5 {
  public static class Battlefield {
    public static void StartDuel(Character character1, Character character2) {
      var battleOver = false;
      var randomGenerator = new Random();

      while (battleOver == false) {
        int coinToss = randomGenerator.Next(2);

        if (coinToss == 1) {
          character1.Attack(character2);
        } else {
          character2.Attack(character1);
        }

        System.Threading.Thread.Sleep(1200);
        Console.WriteLine("---------------");
        Console.WriteLine($"{character1.Name} {character1.Health}HP");
        Console.WriteLine($"{character2.Name} {character2.Health}HP");
        Console.WriteLine("---------------");
        System.Threading.Thread.Sleep(2000);

        if (character1.Health == 0 || character2.Health == 0) {
          battleOver = true;
        }
      }
    }
  }
}
