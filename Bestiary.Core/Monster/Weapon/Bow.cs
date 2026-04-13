using System;

namespace Bestiary.Core.Monster.Weapon;

public class Bow : IDamaging
{
    public void TakeDamage(MonsterBase monster)
    {
        monster.Health -= 10;
    }
}