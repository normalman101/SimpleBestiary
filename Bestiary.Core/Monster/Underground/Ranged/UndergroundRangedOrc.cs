using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный орк кидает дубину");
    }
}