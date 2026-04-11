using System;

namespace Bestiary.Core.Monster.Forest;

public class ForestCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной крипер шахидничает");
    }
}