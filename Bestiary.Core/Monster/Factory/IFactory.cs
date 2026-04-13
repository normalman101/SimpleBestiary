using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Factory;

public interface IFactory
{
    MonsterBase CreateCreeper(uint health, IBiome biome, IDamaging weapon);

    MonsterBase CreateEnderman(uint health, IBiome biome, IDamaging weapon);

    MonsterBase CreateGoblin(uint health, IBiome biome, IDamaging weapon);

    MonsterBase CreateOrc(uint health, IBiome biome, IDamaging weapon);

    MonsterBase CreateSkeleton(uint health, IBiome biome, IDamaging weapon);

    MonsterBase CreateSlime(uint health, IBiome biome, IDamaging weapon);

    MonsterBase CreateTroll(uint health, IBiome biome, IDamaging weapon);
}