using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной энедермен кидается с дальней дистанции");
    }
}