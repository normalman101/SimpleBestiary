using System.Collections.Generic;
using System.Linq;
using Bestiary.Core.Items;

namespace Bestiary.Core.Entities;

public class Character
{
    public List<IItem> Bags { get; } = [];

    public Character Add(IItem bag)
    {
        Bags.Add(bag);
        return this;
    }
    
    public int CalculateTotalWeight()
    {
        return Bags.Sum(b => b.Weight);
    }
}