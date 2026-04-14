using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster;

public abstract class MonsterBase(int health, IBiome biome, IDamaging weapon) : IDamaging
{
    public int Health
    {
        get;
        set => field = value < 0 ? 0 : value;
    } = health;

    public IBiome Biome { get; } = biome;
    public IDamaging Weapon { get; } = weapon;
    public abstract void ApplyDamage(MonsterBase monster);
}