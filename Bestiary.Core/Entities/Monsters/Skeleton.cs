using System;
using Bestiary.Core.Biomes;
using Bestiary.Core.Entities.Abstractions;

namespace Bestiary.Core.Entities.Monsters;

public class Skeleton(int health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void ApplyDamage(MonsterBase monster)
    {
        Console.WriteLine("Скелет стреляет из лука");
        Weapon.ApplyDamage(monster);
    }
}