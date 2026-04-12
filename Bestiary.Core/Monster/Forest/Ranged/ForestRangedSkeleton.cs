using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной скелет стреляет из лука");
    }
}