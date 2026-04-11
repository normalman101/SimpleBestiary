using System;

namespace Bestiary.Core.Monster.Classic;

public class Skeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Скелет стреляет из лука");
    }
}