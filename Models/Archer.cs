using System;
using Potyczka.Weapons;

namespace Potyczka.Models;

public class Archer : Character
{

    
    public Archer(string name) : base(name, health: 150, strength: 25)
    {
        
    }

    public override void UseWeapon()
    {
        Weapon = new Bow();
        Console.WriteLine($"{Name} otrzymał {Weapon.Name} o mocy {Weapon.Damage}");
    }
}

