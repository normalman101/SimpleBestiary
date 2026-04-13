using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Forest;

public class ForestCreeper(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Лесной крипер шахидничает");
        Weapon.TakeDamage(monster);
    }
}