using System;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundOrc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Подземный орк замахивается длинным булыжником");
    }
}