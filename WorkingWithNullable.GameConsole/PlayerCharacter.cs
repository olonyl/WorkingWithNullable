using System;

namespace WorkingWithNullable.GameConsole
{
    public class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;
        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }
        public string Name { get; set; }
        public int Helth { get; set; } = 100;
        public void Hit(int damage)
        {
            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Helth -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Helth}");
        }
    }
}
