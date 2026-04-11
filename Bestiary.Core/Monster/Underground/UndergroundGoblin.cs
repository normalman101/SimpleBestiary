using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный гоблин тычет заострённым камнем");
    }
}