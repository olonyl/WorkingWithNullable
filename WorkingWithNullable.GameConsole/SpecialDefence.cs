namespace WorkingWithNullable.GameConsole
{
    public abstract class SpecialDefence
    {
        public abstract int CalculateDamageReduction(int totalDamage);
        public static SpecialDefence Null { get; set; } = new NullDefence();
        private class NullDefence : SpecialDefence
        {
            public override int CalculateDamageReduction(int totalDamage)
            {
                return 0; // no operation / "do nothing" behavior
            }
        }
    }
}
