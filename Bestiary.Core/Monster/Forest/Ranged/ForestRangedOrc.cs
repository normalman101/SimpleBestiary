using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной орк кидает дубину");
    }
}