using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный гоблин бросается ножами");
    }
}