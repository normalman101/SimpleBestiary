using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundCreeper(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Подземный крипер шахидничает");
        Weapon.TakeDamage(monster);
    }
}