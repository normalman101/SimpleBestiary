using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический гоблин тоычет ножом");
    }
}