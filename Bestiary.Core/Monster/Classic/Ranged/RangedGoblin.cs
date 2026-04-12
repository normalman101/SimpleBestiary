using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический гоблин бросается ножами");
    }
}