using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster;

public abstract class MonsterBase(uint health, IBiome biome, IDamaging weapon)
{
    public uint Health { get; set; } = health;
    public IBiome Biome { get; } = biome;
    public IDamaging Weapon { get; } = weapon;
    public abstract void Action(MonsterBase monster);
}