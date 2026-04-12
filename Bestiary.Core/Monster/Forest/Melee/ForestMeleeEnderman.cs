using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной эндермен атакует вблизи");
    }
}