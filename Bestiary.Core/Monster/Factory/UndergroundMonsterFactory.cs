using Bestiary.Core.Monster.Underground;

namespace Bestiary.Core.Monster.Factory;

public class UndergroundMonsterFactory : IFactory
{
    public IMonster CreateCreeper() => new UndergroundCreeper();

    public IMonster CreateEnderman() => new UndergroundEnderman();

    public IMonster CreateGoblin() => new UndergroundGoblin();

    public IMonster CreateOrc() => new UndergroundOrc();

    public IMonster CreateSkeleton() => new UndergroundSkeleton();

    public IMonster CreateSlime() => new UndergroundSlime();

    public IMonster CreateTroll() => new UndergroundTroll();
}