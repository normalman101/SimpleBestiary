using System;
using Bestiary.Core.Biomes;
using Bestiary.Core.Entities.Abstractions;

namespace Bestiary.Core.Entities.Monsters;

public class Creeper(int health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void ApplyDamage(MonsterBase monster)
    {
        Console.WriteLine("Крипер шахидничает");
        Weapon.ApplyDamage(monster);
    }
}