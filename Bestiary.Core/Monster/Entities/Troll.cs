using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Troll(int health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void ApplyDamage(MonsterBase monster)
    {
        Console.WriteLine("Тролль кидает огромный камень");
        Weapon.ApplyDamage(monster);
    }
}