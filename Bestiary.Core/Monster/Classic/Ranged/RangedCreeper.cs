using System;

namespace Bestiary.Core.Monster.Classic.Ranged;

public class RangedCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический крипер пуляется бомбами");
    }
}