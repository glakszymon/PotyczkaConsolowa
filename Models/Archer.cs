using System;

namespace Potyczka.Models;

public class Archer : Character
{

    
    public Archer(string name) : base(name, health: 150, strength: 25)
    {
        
    }

    public override void UseWeapon()
    {
        WeaponPower = 15;
        Console.WriteLine($"{Name} otrzymał Łuk");
    }
}

