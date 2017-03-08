using System;

namespace Kata5 {
    public class Program {
        public static void Main(string[] args) {
            var player = new Player("Megaman");
            player.Strength = 10;
            player.Health = 100;

            var enemy = new Enemy("Woodman");
            enemy.Strength = 10;
            enemy.Health = 100;

            Battlefield.StartDuel(player, enemy);

            if (player.Health == 0) {
                Console.WriteLine($"{enemy.Name} executed {player.Name}. GAME OVER");
            } else {
                Console.WriteLine($"{enemy.Name} was slain by {player.Name}!");
            }
        }
    }
}
