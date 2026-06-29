using System;
using Potyczka.Weapons;

namespace Potyczka.Roles.Models;

public class Mage : Character
{
    
    public Mage(string name, Random random) : base(name, health: 100, strength: 30, random)
    {}

}

