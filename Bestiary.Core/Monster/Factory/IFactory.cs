namespace Bestiary.Core.Monster.Factory;

public interface IFactory
{
    IMonster CreateCreeper();

    IMonster CreateEnderman();

    IMonster CreateGoblin();

    IMonster CreateOrc();

    IMonster CreateSkeleton();

    IMonster CreateSlime();

    IMonster CreateTroll();
}