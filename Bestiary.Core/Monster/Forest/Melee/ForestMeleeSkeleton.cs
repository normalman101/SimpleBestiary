using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной скелет машет мечом");
    }
}