using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class UndergroundMeleeCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный крипер шахидничает вблизи");
    }
}