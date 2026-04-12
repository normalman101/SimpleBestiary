using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный тролль машет камнем");
    }
}