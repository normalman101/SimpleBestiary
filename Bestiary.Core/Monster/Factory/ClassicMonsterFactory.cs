using Bestiary.Core.Monster.Classic;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Factory;

public class ClassicMonsterFactory : IFactory
{
    public MonsterBase CreateCreeper(uint health, IDamaging weapon) => new Creeper(health, weapon);

    public MonsterBase CreateEnderman(uint health, IDamaging weapon) => new Enderman(health, weapon);

    public MonsterBase CreateGoblin(uint health, IDamaging weapon) => new Goblin(health, weapon);

    public MonsterBase CreateOrc(uint health, IDamaging weapon) => new Orc(health, weapon);

    public MonsterBase CreateSkeleton(uint health, IDamaging weapon) => new Skeleton(health, weapon);

    public MonsterBase CreateSlime(uint health, IDamaging weapon) => new Slime(health, weapon);

    public MonsterBase CreateTroll(uint health, IDamaging weapon) => new Troll(health, weapon);
}