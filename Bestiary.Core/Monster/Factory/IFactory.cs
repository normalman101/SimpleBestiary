using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Factory;

public interface IFactory
{
    MonsterBase CreateCreeper(uint health, IDamaging weapon);

    MonsterBase CreateEnderman(uint health, IDamaging weapon);

    MonsterBase CreateGoblin(uint health, IDamaging weapon);

    MonsterBase CreateOrc(uint health, IDamaging weapon);

    MonsterBase CreateSkeleton(uint health, IDamaging weapon);

    MonsterBase CreateSlime(uint health, IDamaging weapon);

    MonsterBase CreateTroll(uint health, IDamaging weapon);
}