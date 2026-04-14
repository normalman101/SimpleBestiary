using Bestiary.Core.Biomes;
using Bestiary.Core.Entities.Abstractions;
using Bestiary.Core.Entities.Monsters;

namespace Bestiary.Core.Entities.Factory;

public class MonsterFactory : IFactory
{
    public MonsterBase CreateCreeper(int health, IBiome biome, IDamaging weapon) => new Creeper(health, biome, weapon);

    public MonsterBase CreateEnderman(int health, IBiome biome, IDamaging weapon) => new Enderman(health, biome, weapon);

    public MonsterBase CreateGoblin(int health, IBiome biome, IDamaging weapon) => new Goblin(health, biome, weapon);

    public MonsterBase CreateOrc(int health, IBiome biome, IDamaging weapon) => new Orc(health, biome, weapon);

    public MonsterBase CreateSkeleton(int health, IBiome biome, IDamaging weapon) => new Skeleton(health, biome, weapon);

    public MonsterBase CreateSlime(int health, IBiome biome, IDamaging weapon) => new Slime(health, biome, weapon);

    public MonsterBase CreateTroll(int health, IBiome biome, IDamaging weapon) => new Troll(health, biome, weapon);
}