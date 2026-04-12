using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной слизень атакует, прыгая");
    }
}