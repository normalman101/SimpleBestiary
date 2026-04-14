using System.Collections.Generic;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster;

public class MonsterHorde() : IDamaging
{
    public List<MonsterBase> Horde { get; } = [];

    public MonsterHorde Add(MonsterBase monster)
    {
        Horde.Add(monster);
        return this;
    }
    public void ApplyDamage(MonsterBase monster) => Horde.ForEach(m => m.ApplyDamage(monster));
}