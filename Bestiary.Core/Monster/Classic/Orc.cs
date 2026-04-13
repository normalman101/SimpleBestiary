using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Orc(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Орк замахивается дубиной");
        Weapon.TakeDamage(monster);
    }
}