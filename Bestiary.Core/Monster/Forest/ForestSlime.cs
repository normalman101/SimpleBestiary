using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestSlime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной слизень прыгает, атакуя");
    }
}