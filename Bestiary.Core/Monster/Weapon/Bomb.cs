namespace Bestiary.Core.Monster.Weapon;

public class Bomb : IDamaging
{
    public void TakeDamage(MonsterBase monster)
    {
        monster.Health -= 50;
    }
}