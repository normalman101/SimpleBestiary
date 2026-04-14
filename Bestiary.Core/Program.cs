using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Bestiary.Core.Biomes;
using Bestiary.Core.Entities;
using Bestiary.Core.Entities.Monsters;
using Bestiary.Core.Items.Loot;
using Bestiary.Core.Items.Weapons;


var character = new Character();
var weapon = new Sword("The Greatest", 25);
var potion = new Potion("Healthy", 5);
var weapon2 = new Bow("Long", 34);
var bag = new Bag("Simple bag", 3);
var potion2 = new Potion("Jumper", 7);

bag.Add(potion).Add(weapon2);
character.AddInLooseItems(weapon);
character.AddInBags(bag).AddInBags(potion2);
Console.WriteLine(character.CalculateTotalWeight());