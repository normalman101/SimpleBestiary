using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический орк кидает дубину");
    }
}