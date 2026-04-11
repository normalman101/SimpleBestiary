using System;

namespace Bestiary.Core.Monster.Classic;

public class Orc : IMonster
{
    public void Action()
    {
        Console.WriteLine("Орк замахивается дубиной");
    }
}