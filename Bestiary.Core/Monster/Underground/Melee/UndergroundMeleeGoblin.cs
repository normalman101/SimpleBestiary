using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Педземный гоблин тоычет ножом");
    }
}