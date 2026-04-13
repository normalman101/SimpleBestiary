using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Skeleton(uint health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Скелет стреляет из лука");
        Weapon.ApplyDamage(monster);
    }
}