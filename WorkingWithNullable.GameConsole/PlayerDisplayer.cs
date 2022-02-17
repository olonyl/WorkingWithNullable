using System;

namespace WorkingWithNullable.GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin == -1)
            {
                Console.WriteLine("No value for DaySinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if (player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("No value for DateOfBirth");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }
    }
}
