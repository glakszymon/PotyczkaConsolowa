using System;
using Potyczka.Extra;
using Potyczka.Roles.ModelsCreators;
using Potyczka.Weapons;

namespace Potyczka.Roles;

public class Character 
{
    private readonly Random random;

    public string Name { get; set; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    // public int WeaponPower { get; protected set; } 

    public IWeapon Weapon {get; protected set; }

    public Character(string name, int health, int strength, Random random)
    {
        Name = name;
        Health = health;
        Strength = strength;
        this.random = random;
    }


    public AttackerResponse Attack() 
    {
        double randomNumberForLuck = random.Next(40) - 20.0;

        double changePower = randomNumberForLuck / 100.0; 

        int attackStrengthSummary = Strength + Weapon.Damage;
        int damageModifier = (int)(attackStrengthSummary * changePower);

        return new AttackerResponse(attackStrengthSummary + damageModifier, attackStrengthSummary, damageModifier);
    }

    private bool CheckIsALive ()
    {

        if(Health <= 0)
        {
            return false;
        }
        
        return true;
    }

    public DefenderResponse ReciveDamage (int Points)
    {
        int ArmorSafer = 0;
        int FinalDamage = Points - ArmorSafer;

        if(Health - Points < 0)
            Health = 0;
        else
            Health -= Points;

        return new DefenderResponse(FinalDamage, Points, ArmorSafer, CheckIsALive());
    }

    public void UseWeapon(IWeapon ChosenWeapon)
    {
        Weapon = ChosenWeapon;
    }

}