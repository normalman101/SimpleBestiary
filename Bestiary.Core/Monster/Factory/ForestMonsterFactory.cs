using Bestiary.Core.Monster.Forest;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Factory;

public class ForestMonsterFactory : IFactory
{
    public MonsterBase CreateCreeper(uint health, IDamaging weapon) => new ForestCreeper(health, weapon);

    public MonsterBase CreateEnderman(uint health, IDamaging weapon) => new ForestEnderman(health, weapon);

    public MonsterBase CreateGoblin(uint health, IDamaging weapon) => new ForestGoblin(health, weapon);

    public MonsterBase CreateOrc(uint health, IDamaging weapon) => new ForestOrc(health, weapon);

    public MonsterBase CreateSkeleton(uint health, IDamaging weapon) => new ForestSkeleton(health, weapon);

    public MonsterBase CreateSlime(uint health, IDamaging weapon) => new ForestSlime(health, weapon);

    public MonsterBase CreateTroll(uint health, IDamaging weapon) => new ForestTroll(health, weapon);
}