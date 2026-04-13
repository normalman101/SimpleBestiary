using System;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Classic;

public class Enderman(uint health, IDamaging weapon) : MonsterBase(health, weapon)
{
    
    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Эндермен атакует, телепортируясь");
        Weapon.ApplyDamage(monster);
    }
}