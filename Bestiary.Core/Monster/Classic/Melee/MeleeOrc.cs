using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический орк машет дубиной");
    }
}