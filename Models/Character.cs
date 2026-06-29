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
        Console.WriteLine($"[{Name}] HP: {Health} | STR: {Strength}");
    }

    public int Atack()
    {
        int AtackStrengthSummary = Strength + WeaponPower;
        return AtackStrengthSummary;
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