using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Orc(int health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public override void ApplyDamage(MonsterBase monster)
    {
        Console.WriteLine("Орк замахивается дубиной");
        Weapon.ApplyDamage(monster);
    }
}