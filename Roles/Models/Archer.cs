using System;
using Potyczka.Weapons;

namespace Potyczka.Roles.Models;

public class Archer : Character
{
    public Archer(string name, Random random) : base(name, health: 150, strength: 25, random)
    {
        AllowedWeapons.Add(new Bow());
        AllowedWeapons.Add(new Sword());
        AllowedWeapons.Add(new NoWeapon());
    }
}

