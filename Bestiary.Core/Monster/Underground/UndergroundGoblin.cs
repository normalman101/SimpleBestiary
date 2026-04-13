using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundGoblin(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Подземный гоблин тычет заострённым камнем");
        Weapon.TakeDamage(monster);
    }
}