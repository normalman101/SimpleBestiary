using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный энедермен кидается с дальней дистанции");
    }
}