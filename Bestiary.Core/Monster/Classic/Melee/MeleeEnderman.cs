using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический эндермен атакует вблизи");
    }
}