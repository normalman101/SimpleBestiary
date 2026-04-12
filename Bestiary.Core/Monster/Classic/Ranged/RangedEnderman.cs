using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический энедермен кидается с дальней дистанции");
    }
}