using Bestiary.Core.Monster.Classic;

namespace Bestiary.Core.Monster.Factory;

public class ClassicMonsterFactory : IFactory
{
    public IMonster CreateCreeper() => new Creeper();

    public IMonster CreateEnderman() => new Enderman();

    public IMonster CreateGoblin() => new Goblin();

    public IMonster CreateOrc() => new Orc();

    public IMonster CreateSkeleton() => new Skeleton();

    public IMonster CreateSlime() => new Slime();

    public IMonster CreateTroll() => new Troll();
}