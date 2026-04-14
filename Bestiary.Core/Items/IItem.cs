namespace Bestiary.Core.Items;

public interface IItem
{
    string Name { get; }
    int Weight { get; protected set; }
}