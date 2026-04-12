using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной тролль машет камнем");
    }
}