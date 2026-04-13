namespace Bestiary.Core.Monster.Weapon;

public class Bomb : IDamaging
{
    public void ApplyDamage(MonsterBase monster)
    {
        monster.Health -= 50;
    }
}