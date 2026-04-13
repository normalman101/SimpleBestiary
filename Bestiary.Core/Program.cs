using System;
using System.Collections.Generic;
using Bestiary.Core.Monster;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Boss;
using Bestiary.Core.Monster.Classic;
using Bestiary.Core.Monster.Entities;
using Bestiary.Core.Monster.Weapon;

var monster2 = new Creeper(100, new Forest(), new Bomb());
var monster1 = new Goblin(100, new Forest(), new Sword());

monster2.Action(monster1);
Console.WriteLine(monster1.Health);