using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class ForestMeleeCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Лесной крипер шахидничает вблизи");
    }
}