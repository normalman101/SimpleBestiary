using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический тролль кидает огромный камень");
    }
}