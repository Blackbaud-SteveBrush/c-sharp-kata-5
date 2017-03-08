using System;

namespace Kata5 {
  public class Enemy : Character, IEvadable {
    private Random _randomGenerator;
    public float ChanceToEvade { get; set; } = 0.25F;

    public Enemy(string name) : base(name) {
       _randomGenerator = new Random();
    }

    public bool AttemptEvasion() {
      var diceRoll = _randomGenerator.Next(1, 101);
      return (diceRoll < (ChanceToEvade * 100));
    }
  }
}