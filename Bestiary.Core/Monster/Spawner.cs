using Bestiary.Core.Monster.Forest;
using Bestiary.Core.Monster.Underground;

namespace Bestiary.Core.Monster;

public class Spawner
{
    public IMonster? SpawnMonster(string type, string locationType)
    {
        if (locationType == "Forest")
        {
            if (type == "ForestGoblin")
            {
                return new ForestGoblin();
            } else if (type == "ForestOrc")
            {
                return new ForestOrc();
            } else if (type == "ForestSkeleton")
            {
                return new ForestSkeleton();
            } else if (type == "ForestSlime")
            {
                return new ForestSlime();
            } else if (type == "ForestTroll")
            {
                return new ForestTroll();
            }
        } else if (locationType == "Underground")
        {
            if (type == "UndergroundGoblin")
            {
                return new UndergroundGoblin();
            } else if (type == "UndergroundOrc")
            {
                return new UndergroundOrc();
            } else if (type == "UndergroundSkeleton")
            {
                return new UndergroundSkeleton();
            } else if (type == "UndergroundSlime")
            {
                return new UndergroundSlime();
            } else if (type == "UndergroundTroll")
            {
                return new UndergroundTroll();
            }
        }
        return null;
    }
}