using Bestiary.Core.Entities.Abstractions;
using Bestiary.Core.Entities.Monsters;

namespace Bestiary.Core.Entities;

public interface IDamaging
{
    void ApplyDamage(MonsterBase monster);
}