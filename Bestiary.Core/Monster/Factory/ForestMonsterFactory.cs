using Bestiary.Core.Monster.Forest;

namespace Bestiary.Core.Monster.Factory;

public class ForestMonsterFactory : IFactory
{
    public IMonster CreateCreeper() => new ForestCreeper();

    public IMonster CreateEnderman() => new ForestEnderman();

    public IMonster CreateGoblin() => new ForestGoblin();

    public IMonster CreateOrc() => new ForestOrc();

    public IMonster CreateSkeleton() => new ForestSkeleton();

    public IMonster CreateSlime() => new ForestSlime();

    public IMonster CreateTroll() => new ForestTroll();
}