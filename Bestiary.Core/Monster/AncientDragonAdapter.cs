namespace Bestiary.Core.Monster;

public class AncientDragonAdapter(AncientDragon ancientDragon) : IMonster
{
    public AncientDragon AncientDragon { get; } = ancientDragon;

    public void Action()
    {
        AncientDragon.Roar();
        AncientDragon.Fly();
    }
}