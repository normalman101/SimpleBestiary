using System;

namespace Bestiary.Core.Monster.Classic;

public class Slime : IMonster
{
    public void Action()
    {
        Console.WriteLine("Слизень прыгает, атакуя");
    }
}