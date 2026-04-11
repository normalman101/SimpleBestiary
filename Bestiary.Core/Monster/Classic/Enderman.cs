using System;

namespace Bestiary.Core.Monster.Classic;

public class Enderman : IMonster
{
    public void Action()
    {
        Console.WriteLine("Эндермен атакует, телепортируясь");
    }
}