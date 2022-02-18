using System;

namespace WorkingWithNullable.GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();

            player.DaysSinceLastLogin = 42;


            //Null Conditional Operator + Null Coalescing Operator
            int days = player?.DaysSinceLastLogin ?? -1;

            Console.WriteLine(days);

            Console.ReadLine();

        }
    }
}
