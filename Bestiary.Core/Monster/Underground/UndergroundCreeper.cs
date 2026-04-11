using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный крипер шахидничает");
    }
}