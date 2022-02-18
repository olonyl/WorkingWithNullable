using System;

namespace WorkingWithNullable.GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();

            //player.Name = " ";
            player.DaysSinceLastLogin = 42;
            //player.DateOfBirth = DateTime.Now;

            PlayerDisplayer.Write(player);

            Console.ReadLine();

        }
    }
}
