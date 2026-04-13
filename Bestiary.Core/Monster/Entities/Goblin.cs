using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Goblin(uint health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Гоблин тычет ножом");
        Weapon.ApplyDamage(monster);
    }
}