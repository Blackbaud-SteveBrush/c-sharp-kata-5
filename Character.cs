using System;

namespace Kata5 {
  public abstract class Character {
    public string Name { get; set; }
    public int Strength { get; set; }
    private int _health;
    public int Health { 
      get { return _health; }
      set {
        if (value < 0) {
          value = 0;
        }
        _health = value;
      }
    }

    public Character(string name) {
      Name = name;
    }

    public void Attack(Character character) {
      Console.WriteLine($"{Name} attacks {character.Name}...");
      System.Threading.Thread.Sleep(1200);

      if (character is IEvadable) {
        var evadableCharacter = (IEvadable)character;
        if (evadableCharacter.AttemptEvasion()) {
          Console.WriteLine($" --> {character.Name} dodged the attack!");
          return;
        }
      }

      Console.WriteLine($" --> {character.Name} takes {Strength} points of damage.");
      character.Health -= Strength;
    }
  }
}