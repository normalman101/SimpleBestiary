using System;

namespace Bestiary.Core.Monster.Weapon;

public class Sword : IDamaging
{
    public void TakeDamage(MonsterBase monster)
    {
        monster.Health -= 20;
    }
}