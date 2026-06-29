using System;
using System.Runtime.InteropServices;
using Potyczka.Weapons;

namespace Potyczka.Roles.Models;

public class Warrior : Character
{
    public Warrior(string name, Random random) : base(name, health: 150, strength: 25, random)
    {}
}

