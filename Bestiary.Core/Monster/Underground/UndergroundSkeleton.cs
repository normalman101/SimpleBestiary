using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundSkeleton : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный скелет стреляет из лука заострёнными тонкими камнями");
    }
}