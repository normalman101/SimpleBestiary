using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Forest;

public class ForestGoblin(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Лесной гоблин тычет палкой");
        Weapon.TakeDamage(monster);
    }
}