using System;

namespace Potyczka.Models;

public class Mage : Character
{
    
    public Mage(string name) : base(name, health: 100, strength: 30)
    {
        
    }

    public override void UseWeapon()
    {
        WeaponPower = 30;
        Console.WriteLine($"{Name} otrzymał Patyk");
    }
}

