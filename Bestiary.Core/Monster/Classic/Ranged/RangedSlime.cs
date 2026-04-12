using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический слизень бросает слизь");
    }
}