using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный орк машет дубиной");
    }
}