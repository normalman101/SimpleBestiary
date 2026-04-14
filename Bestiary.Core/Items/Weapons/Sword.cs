using Bestiary.Core.Entities;
using Bestiary.Core.Entities.Abstractions;

namespace Bestiary.Core.Items.Weapons;

public class Sword(string name, int weight) : IItem, IDamaging
{
    public string Name { get; } = name;
    public int Weight { get; set; } = weight;
    
    public void ApplyDamage(MonsterBase monster)
    {
        monster.Health -= 20;
    }
}