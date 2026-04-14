namespace Bestiary.Core.Entities;

public abstract class AliveEntityBase
{
    public int Health
    {
        get;
        set => field = value > field ? 0 : value;
    }
}