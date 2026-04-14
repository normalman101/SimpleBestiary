using Bestiary.Core.Biomes;

namespace Bestiary.Core.Entities.Abstractions;

public abstract class MonsterBase(int health, IBiome biome, IDamaging weapon) : AliveEntityBase, IDamaging
{
    public IBiome Biome { get; } = biome;
    public IDamaging Weapon { get; } = weapon;
    public abstract void ApplyDamage(MonsterBase monster);
}