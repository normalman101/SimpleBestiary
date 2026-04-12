using System.Collections.Generic;
using Bestiary.Core.Monster;

Boss boss = new Boss.Builder()
    .SetName("Boss")
    .SetHealth(200)
    .SetAgility(1)
    .SetArmorType("Silver")
    .SetElement("Fire")
    .Build();


var dragon = new AncientDragon();
var dragonWrapper = new AncientDragonAdapter(dragon);

var monsters2 = new List<IMonster> {boss, dragonWrapper};
monsters2.ForEach(m => m.Action());