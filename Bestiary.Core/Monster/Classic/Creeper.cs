using System;

namespace Bestiary.Core.Monster.Classic;

public class Creeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Крипер шахидничает");
    }
}