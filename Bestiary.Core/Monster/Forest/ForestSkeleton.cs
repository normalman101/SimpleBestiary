using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной скелет стреляет из лука палками");
    }
}