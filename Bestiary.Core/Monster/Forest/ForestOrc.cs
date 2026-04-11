using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной орк замахивается деревом");
    }
}