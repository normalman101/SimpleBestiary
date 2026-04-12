using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический скелет стреляет из лука");
    }
}