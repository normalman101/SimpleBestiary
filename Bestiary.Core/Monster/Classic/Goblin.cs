using System;

namespace Bestiary.Core.Monster.Classic;

public class Goblin : IMonster
{
    public void Action()
    {
        Console.WriteLine("Гоблин тычет ножом");
    }
}