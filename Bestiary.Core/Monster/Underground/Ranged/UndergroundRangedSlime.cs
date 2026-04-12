using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный слизень бросает слизь");
    }
}