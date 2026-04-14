using System.Collections.Generic;
using Bestiary.Core.Entities.Abstractions;
using Bestiary.Core.Entities.Monsters;

namespace Bestiary.Core.Entities;

public class MonsterHorde : IDamaging
{
    public List<IDamaging> Horde { get; } = [];

    public MonsterHorde Add(IDamaging element)
    {
        Horde.Add(element);
        return this;
    }
    public void ApplyDamage(MonsterBase monster) => Horde.ForEach(m => m.ApplyDamage(monster));
    public int Health { get; set; }
}