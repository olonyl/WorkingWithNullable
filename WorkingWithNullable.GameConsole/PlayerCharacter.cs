﻿using System;

namespace WorkingWithNullable.GameConsole
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
    }
}
