using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class UndergroundRangedCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный крипер пуляется бомбами");
    }
}