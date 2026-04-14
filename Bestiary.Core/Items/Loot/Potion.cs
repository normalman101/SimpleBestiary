namespace Bestiary.Core.Items.Loot;

public class Potion(string name, int weight) : IItem
{
    public string Name { get; } = name;
    public int Weight { get; set; } = weight;
}