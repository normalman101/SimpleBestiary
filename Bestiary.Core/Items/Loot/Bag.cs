using System.Collections.Generic;
using System.Linq;

namespace Bestiary.Core.Items.Loot;

public class Bag(string name, int weight) : IItem
{
    public string Name { get; } = name;
    public int Weight { get; set; } = weight;
    public List<IItem> Items { get; } = [];

    public Bag Add(IItem item)
    {
        Items.Add(item);
        Weight += item.Weight;
        return this;
    }
    public IItem? Get(string name) => (IItem)Items.Where(i => i.Name == name);

}