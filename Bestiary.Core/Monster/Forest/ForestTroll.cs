using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestTroll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной тролль кидает огромное бревно");
    }
}