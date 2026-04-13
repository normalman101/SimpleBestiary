namespace Bestiary.Core.Monster.Weapon;

public class Fists : IDamaging
{
    public void ApplyDamage(MonsterBase monster)
    {
        monster.Health -= 5;
    }
}