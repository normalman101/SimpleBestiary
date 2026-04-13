using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundOrc(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Подземный орк замахивается длинным булыжником");
        Weapon.TakeDamage(monster);
    }
}