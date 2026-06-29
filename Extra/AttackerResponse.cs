
namespace Potyczka.Extra;

public class AttackerResponse
{
    public int FinalAttack { get; private set;}
    public int PotentialPointsForAttack { get; private set; }
    public int HitFactor { get; private set; }

    public AttackerResponse(int finalAttack, int potentialPointsForAttack, int hitFactor)
    {
        FinalAttack = finalAttack;
        PotentialPointsForAttack = potentialPointsForAttack;
        HitFactor = hitFactor;
    }
}