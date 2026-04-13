using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Entities;

public class Creeper(uint health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Крипер шахидничает");
        Weapon.ApplyDamage(monster);
    }
}