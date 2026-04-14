using System;
using Bestiary.Core.Entities;
using Bestiary.Core.Items.Loot;
using Bestiary.Core.Items.Weapons;


var character = new Character();
var weapon = new Sword("The Greatest", 25);
var potion = new Potion("Healthy", 5);
var weapon2 = new Bow("Long", 34);
var bag = new Bag("Simple bag", 3);
var potion2 = new Potion("Jumper", 7);

bag.Add(potion).Add(weapon2);
var bag2 = new Bag("Complex bag", 2);
bag2.Add(weapon).Add(bag);
character.Add(bag).Add(potion2).Add(bag2);
Console.WriteLine(character.CalculateTotalWeight());