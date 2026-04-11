using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestGoblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной гоблин тычет палкой");
    }
}