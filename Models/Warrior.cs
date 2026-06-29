using System;

namespace Potyczka.Models;

public class Warrior : Character
{
    public Warrior(string name) : base(name, health: 150, strength: 25)
    {}

    public override void UseWeapon()
    {
        WeaponPower = 10;
        Console.WriteLine($"{Name} otrzymał Miecz");
    }
}

