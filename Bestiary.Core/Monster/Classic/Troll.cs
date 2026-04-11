using System;

namespace Bestiary.Core.Monster.Classic;

public class Troll : IMonster
{
    public void Action()
    {
        Console.WriteLine("Тролль кидает огромный камень");
    }
}