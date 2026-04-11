using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный тролль кидает огромный булыжник");
    }
}