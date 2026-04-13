using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Forest;

public class ForestSkeleton(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Лесной скелет стреляет из лука палками");
        Weapon.TakeDamage(monster);
    }
}