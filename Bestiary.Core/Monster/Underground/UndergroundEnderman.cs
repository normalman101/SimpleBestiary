using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundEnderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный эндермен атакует, телепортируясь");
    }
}