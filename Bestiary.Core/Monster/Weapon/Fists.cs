namespace Bestiary.Core.Monster.Weapon;

public class Fists : IDamaging
{
    public void TakeDamage(MonsterBase monster)
    {
        monster.Health -= 5;
    }
}