using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Boss;

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