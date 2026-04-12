using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной гоблин бросается ножами");
    }
}