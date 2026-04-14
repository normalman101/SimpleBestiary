using System;
using System.Collections.Generic;
using Bestiary.Core.Monster;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Classic;
using Bestiary.Core.Monster.Entities;
using Bestiary.Core.Monster.Weapon;

var monster2 = new Creeper(100, new Forest(), new Bomb());
var monster1 = new Goblin(100, new Forest(), new Sword());
var monster3 = new Troll(200, new Underground(), new Fists());
var horde = new MonsterHorde()
    .Add(monster1)
    .Add(monster2)
    .Add(monster3);

var target = new Enderman(100, new Classic(), new Fists());

var hordesAndIndividuals = new List<IDamaging>
{
    monster1,
    monster2,
    monster3,
    horde
};

foreach (var element in hordesAndIndividuals)
{
    element.ApplyDamage(target);
}


Console.WriteLine(target.Health);