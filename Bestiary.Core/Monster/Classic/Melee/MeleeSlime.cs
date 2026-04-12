using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический слизень атакует, прыгая");
    }
}