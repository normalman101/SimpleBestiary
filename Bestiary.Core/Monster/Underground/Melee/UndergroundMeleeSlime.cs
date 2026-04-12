using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный слизень атакует, прыгая");
    }
}