using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Classic;
using Bestiary.Core.Monster.Entities;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Factory;

public class MonsterFactory : IFactory
{
    public MonsterBase CreateCreeper(uint health, IBiome biome, IDamaging weapon) => new Creeper(health, biome, weapon);

    public MonsterBase CreateEnderman(uint health, IBiome biome, IDamaging weapon) => new Enderman(health, biome, weapon);

    public MonsterBase CreateGoblin(uint health, IBiome biome, IDamaging weapon) => new Goblin(health, biome, weapon);

    public MonsterBase CreateOrc(uint health, IBiome biome, IDamaging weapon) => new Orc(health, biome, weapon);

    public MonsterBase CreateSkeleton(uint health, IBiome biome, IDamaging weapon) => new Skeleton(health, biome, weapon);

    public MonsterBase CreateSlime(uint health, IBiome biome, IDamaging weapon) => new Slime(health, biome, weapon);

    public MonsterBase CreateTroll(uint health, IBiome biome, IDamaging weapon) => new Troll(health, biome, weapon);
}