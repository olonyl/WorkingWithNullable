using System;

namespace WorkingWithNullable.GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter[] players = new PlayerCharacter[] {
            new PlayerCharacter{Name="Olonyl"},
            new PlayerCharacter(),
            null
            };


            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;


            PlayerCharacter[] players2 = null;


            string p21 = players2?[0]?.Name;
            string p22 = players2?[1]?.Name;
            string p23 = players2?[2]?.Name;


            //Null Conditional Operator + Null Coalescing Operator
            PlayerCharacter player = null;
            int days = player?.DaysSinceLastLogin ?? -1;
            Console.WriteLine(days);

            Console.ReadLine();

        }
    }
}
