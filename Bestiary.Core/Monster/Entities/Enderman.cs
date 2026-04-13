using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Enderman(uint health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Эндермен атакует, телепортируясь");
        Weapon.ApplyDamage(monster);
    }
}