using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной слизень бросает слизь");
    }
}