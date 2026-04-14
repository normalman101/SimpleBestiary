using Bestiary.Core.Biomes;
using Bestiary.Core.Entities.Abstractions;

namespace Bestiary.Core.Entities.Bosses;

public class AncientDragonAdapter(AncientDragon ancientDragon, int health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public AncientDragon AncientDragon { get; } = ancientDragon;

    public override void ApplyDamage(MonsterBase monster)
    {
        AncientDragon.Roar();
        AncientDragon.Fly();
        Weapon.ApplyDamage(monster);
    }
}