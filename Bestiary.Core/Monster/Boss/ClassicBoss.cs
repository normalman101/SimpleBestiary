using System;
using Bestiary.Core.Monster.Biome;
using Bestiary.Core.Monster.Weapon;

namespace Bestiary.Core.Monster.Boss;

public class ClassicBoss(uint health, IBiome biome, IDamaging weapon) : MonsterBase(health, biome, weapon)
{
    public string? Name { get; private set; }
    public uint? Mana { get; private set; }
    public uint? Strength { get; private set; }
    public uint? Agility { get; private set; }
    public uint? Intelligence { get; private set; }
    public string? WeaponType { get; private set; }
    public string? ArmorType { get; private set; }
    public string? Element { get; private set; }
    public bool? IsImmortal { get; private set; }
    public string? SpecialAbilityName { get; private set; }

    public override void Action(MonsterBase monster)
    {
        Console.WriteLine("Бъёт кувалдой");
    }
    
    public class Builder(uint health, IBiome biome, IDamaging weapon)
    {
        private readonly ClassicBoss _product = new ClassicBoss(health, biome, weapon);
        
        public Builder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public Builder SetHealth(uint health)
        {
            _product.Health = health;
            return this;
        }

        public Builder SetMana(uint mana)
        {
            _product.Mana = mana;
            return this;
        }

        public Builder SetStrength(uint strength)
        {
            _product.Strength = strength;
            return this;
        }

        public Builder SetAgility(uint agility)
        {
            _product.Agility = agility;
            return this;
        }

        public Builder SetIntelligence(uint intelligence)
        {
            _product.Intelligence = intelligence;
            return this;
        }

        public Builder SetWeaponType(string weaponType)
        {
            _product.WeaponType = weaponType;
            return this;
        }

        public Builder SetArmorType(string armorType)
        {
            _product.ArmorType = armorType;
            return this;
        }

        public Builder SetElement(string element)
        {
            _product.Element = element;
            return this;
        }

        public Builder SetImmortality(bool isImmortal)
        {
            _product.IsImmortal = isImmortal;
            return this;
        }

        public Builder SetSpecialAbilityName(string specialAbilityName)
        {
            _product.SpecialAbilityName = specialAbilityName;
            return this;
        }

        public ClassicBoss Build() => _product;

    }
}