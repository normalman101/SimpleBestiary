using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный скелет машет мечом");
    }
}