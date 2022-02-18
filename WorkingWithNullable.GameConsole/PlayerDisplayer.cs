using System;

namespace WorkingWithNullable.GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespaces");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin.Value);
            }
            else
            {
                Console.WriteLine("No value for DaySinceLastLogin");
            }

            if (player.DateOfBirth.HasValue)
            {
                Console.WriteLine(player.DateOfBirth);
            }
            else
            {
                Console.WriteLine("No value for DateOfBirth");
            }
            if (player.IsNoob == null)
            {
                Console.Write("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
