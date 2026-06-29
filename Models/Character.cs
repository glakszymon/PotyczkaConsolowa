using System;

namespace Potyczka.Models;

public class Character
{
    public string Name { get; set; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int WeaponPower { get; protected set; } = 0;

    public Character(string name, int health, int strength)
    {
        Name = name;
        Health = health;
        Strength = strength;
    }

    public virtual void ShowStats()
    {
        Console.WriteLine($"[{Name}] HP: {Health} | STR: {Strength} | WEAPON POWER: {(WeaponPower == 0 ? "Brak" : WeaponPower)} ");
    }

    public int Atack() 
{

    bool isBetterHit = Random.Shared.Next(2) == 0;

    double randomNumberForLuck = Random.Shared.Next(20);
    double changePower = randomNumberForLuck / 100.0; 

    int attackStrengthSummary = Strength + WeaponPower;
    int damageModifier = (int)(attackStrengthSummary * changePower);

    if (isBetterHit)
    {
        Console.WriteLine($"{Name} Atakuje z siła {attackStrengthSummary}. Trafił dokładnie i zwiekszył atak o {damageModifier}");
        return attackStrengthSummary + damageModifier;
    }
    
    Console.WriteLine($"{Name} Atakuje z siła {attackStrengthSummary}. Nie dokładnie uderzył i pogorszył atak o {damageModifier}");
    return attackStrengthSummary - damageModifier;
}
    public bool CheckIsALive ()
    {

        if(Health <= 0)
        {
            return false;
        }
        
        return true;
    }

    public void ReciveDamage (int Points)
    {
        if(Health - Points < 0)
            Health = 0;
        else
            Health -= Points;

        Console.WriteLine($"{Name} otrzymal {Points} punktow obrazen.");

        return;
    }

    public virtual void UseWeapon()
    {
        
    }
}