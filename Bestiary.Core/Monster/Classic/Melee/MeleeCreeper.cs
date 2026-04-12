using System;

namespace Bestiary.Core.Monster.Classic.Melee;

public class MeleeCreeper : IMonster
{
    public void Action()
    {
        Console.WriteLine("Классический крипер шахидничает вблизи");
    }
}