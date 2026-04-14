using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Skeleton(int health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void ApplyDamage(MonsterBase monster)
    {
        Console.WriteLine("Скелет стреляет из лука");
        Weapon.ApplyDamage(monster);
    }
}