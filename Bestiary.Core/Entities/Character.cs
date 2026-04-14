using System.Collections.Generic;
using System.Linq;
using Bestiary.Core.Items;
using Bestiary.Core.Items.Loot;

namespace Bestiary.Core.Entities;

public class Character
{
    public List<IItem> LooseItems { get; } = [];
    public List<IItem> Bags { get; } = [];

    public Character AddInLooseItems(IItem item)
    {
        LooseItems.Add(item);
        return this;
    }

    public Character AddInBags(IItem bag)
    {
        Bags.Add(bag);
        return this;
    }
    
    public int CalculateTotalWeight()
    {
        return LooseItems.Sum(i => i.Weight) + Bags.Sum(b => b.Weight);
    }
}