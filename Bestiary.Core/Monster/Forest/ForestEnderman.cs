using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной эндермен атакует, телепортируясь");
    }
}