using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster;

public abstract class MonsterBase(uint health, IDamaging weapon)
{
    public uint Health { get; set; } = health;
    public IDamaging Weapon { get; } = weapon;
    public abstract void Action(MonsterBase monster);
}