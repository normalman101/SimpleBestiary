using System;

namespace Bestiary.Core.Monster.Weapon;

public class Rock : IDamaging
{
    public void ApplyDamage(MonsterBase monster)
    {
        monster.Health -= 15;
    }
}