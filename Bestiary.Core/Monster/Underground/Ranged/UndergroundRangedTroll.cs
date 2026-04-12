using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный тролль кидает огромный камень");
    }
}