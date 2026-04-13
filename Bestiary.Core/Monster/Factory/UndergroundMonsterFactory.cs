using Bestiary.Core.Monster.Underground;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Factory;

public class UndergroundMonsterFactory : IFactory
{
    public MonsterBase CreateCreeper(uint health, IDamaging weapon) => new UndergroundCreeper(health, weapon);

    public MonsterBase CreateEnderman(uint health, IDamaging weapon) => new UndergroundEnderman(health, weapon);

    public MonsterBase CreateGoblin(uint health, IDamaging weapon) => new UndergroundGoblin(health, weapon);

    public MonsterBase CreateOrc(uint health, IDamaging weapon) => new UndergroundOrc(health, weapon);

    public MonsterBase CreateSkeleton(uint health, IDamaging weapon) => new UndergroundSkeleton(health, weapon);

    public MonsterBase CreateSlime(uint health, IDamaging weapon) => new UndergroundSlime(health, weapon);

    public MonsterBase CreateTroll(uint health, IDamaging weapon) => new UndergroundTroll(health, weapon);
}