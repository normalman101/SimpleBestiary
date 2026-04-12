using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной гоблин тоычет ножом");
    }
}