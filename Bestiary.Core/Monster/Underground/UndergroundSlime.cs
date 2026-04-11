using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный слизень прыгает, атакуя");
    }
}