using System;
using Potyczka.Weapons;

namespace Potyczka.Roles.Models;

public class Mage : Character
{
    
    public Mage(string name, Random random) : base(name, health: 100, strength: 30, random)
    {
        AllowedWeapons.Add(new Staff());
        AllowedWeapons.Add(new Bow());
        AllowedWeapons.Add(new Sword());
        AllowedWeapons.Add(new NoWeapon());
    }

}

