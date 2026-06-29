
namespace Potyczka.Weapons;

public class Bow : IWeapon
{
    public string Name => "Bow";
    public int Damage => 25;  


    public int PerformAttack()
    {
        return Damage;
    }
}