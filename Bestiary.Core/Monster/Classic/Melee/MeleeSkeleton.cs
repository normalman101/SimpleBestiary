using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический скелет машет мечом");
    }
}