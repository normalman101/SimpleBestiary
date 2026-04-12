using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной орк машет дубиной");
    }
}