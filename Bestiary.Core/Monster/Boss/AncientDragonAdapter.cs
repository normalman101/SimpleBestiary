using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Boss;

public class AncientDragonAdapter(AncientDragon ancientDragon, uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public AncientDragon AncientDragon { get; } = ancientDragon;

    public override void Action(MonsterBase monster)
    {
        AncientDragon.Roar();
        AncientDragon.Fly();
    }
}