using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundSlime(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Подземный слизень прыгает, атакуя");
        Weapon.TakeDamage(monster);
    }
}