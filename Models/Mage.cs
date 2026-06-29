using System;
using Potyczka.Weapons;

namespace Potyczka.Models;

public class Mage : Character
{
    
    public Mage(string name) : base(name, health: 100, strength: 30)
    {
        
    }

    public override void UseWeapon()
    {
        Weapon = new Staff();
        Console.WriteLine($"{Name} otrzymał {Weapon.Name} o mocy {Weapon.Damage}");
    }
}

