using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный эндермен атакует вблизи");
    }
}