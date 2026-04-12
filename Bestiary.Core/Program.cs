// See https://aka.ms/new-console-template for more information

using System;
using Bestiary.Core;
using Bestiary.Core.Monster;
using Bestiary.Core.Monster.Factory;

Boss boss = new Boss.Builder()
    .SetName("Boss")
    .SetHealth(200)
    .SetAgility(1)
    .SetArmorType("Silver")
    .SetElement("Fire")
    .Build();

boss.Action();
