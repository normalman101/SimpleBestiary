using System;

namespace Bestiary.Core.Monster.Weapon;

public class Rock : IDamaging
{
    public void TakeDamage(MonsterBase monster)
    {
        monster.Health -= 15;
    }
}