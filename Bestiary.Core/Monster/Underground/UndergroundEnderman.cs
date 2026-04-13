using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Underground;

public class UndergroundEnderman(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Подземный эндермен атакует, телепортируясь");
        Weapon.TakeDamage(monster);
    }
}