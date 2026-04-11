// See https://aka.ms/new-console-template for more information

using System;
using Bestiary.Core;
using Bestiary.Core.Monster;

var Spawner = new Spawner();
var Troll = Spawner.SpawnMonster("Troll", TODO);
var Orc = Spawner.SpawnMonster("Orc", TODO);
Troll.Action();
Orc.Action();