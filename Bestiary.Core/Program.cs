using System;
using System.Collections.Generic;
using Bestiary.Core.Monster;
using Bestiary.Core.Monster.Boss;
using Bestiary.Core.Monster.Forest;
using Bestiary.Core.Monster.Weapon;

var Monster2 = new ForestCreeper(100, new Bomb());
var Monster1 = new ForestGoblin(100, new Sword());

Monster2.Action(Monster1);
Console.WriteLine(Monster1.Health);