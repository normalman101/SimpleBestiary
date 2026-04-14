using System.Collections.Generic;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster;

public class MonsterHorde() : IDamaging
{
    public List<IDamaging> Horde { get; } = [];

    public MonsterHorde Add(IDamaging element)
    {
        Horde.Add(element);
        return this;
    }
    public void ApplyDamage(MonsterBase monster) => Horde.ForEach(m => m.ApplyDamage(monster));
}