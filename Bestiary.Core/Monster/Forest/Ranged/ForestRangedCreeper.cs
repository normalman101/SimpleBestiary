using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class ForestRangedCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной крипер пуляется бомбами");
    }
}