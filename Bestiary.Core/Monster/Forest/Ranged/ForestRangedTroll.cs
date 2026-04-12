using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной тролль кидает огромный камень");
    }
}