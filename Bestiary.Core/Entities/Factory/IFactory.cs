using Bestiary.Core.Biomes;
using Bestiary.Core.Entities.Abstractions;
using Bestiary.Core.Entities.Monsters;

namespace Bestiary.Core.Entities.Factory;

public interface IFactory
{
    MonsterBase CreateCreeper(int health, IBiome biome, IDamaging weapon);

    MonsterBase CreateEnderman(int health, IBiome biome, IDamaging weapon);

    MonsterBase CreateGoblin(int health, IBiome biome, IDamaging weapon);

    MonsterBase CreateOrc(int health, IBiome biome, IDamaging weapon);

    MonsterBase CreateSkeleton(int health, IBiome biome, IDamaging weapon);

    MonsterBase CreateSlime(int health, IBiome biome, IDamaging weapon);

    MonsterBase CreateTroll(int health, IBiome biome, IDamaging weapon);
}