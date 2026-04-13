using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Creeper(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Крипер шахидничает");
        Weapon.TakeDamage(monster);
    }
}