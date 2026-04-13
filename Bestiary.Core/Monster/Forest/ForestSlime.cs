using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Forest;

public class ForestSlime(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Лесной слизень прыгает, атакуя");
        Weapon.TakeDamage(monster);
    }
}