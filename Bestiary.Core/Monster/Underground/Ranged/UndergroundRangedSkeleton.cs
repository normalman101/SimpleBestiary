using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный скелет стреляет из лука");
    }
}