using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический тролль машет камнем");
    }
}