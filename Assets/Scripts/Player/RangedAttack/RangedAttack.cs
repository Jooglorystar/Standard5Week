using UnityEngine;
using UnityEngine.InputSystem;

public interface IRanged
{
    void Shoot(GameObject bullet);
}

public class RangedAttack : MonoBehaviour
{
    private IRanged rangedAttack;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] StraightRangedAttack straight;
    [SerializeField] ParabolaRangedAttack parabola;
    [SerializeField] CircleRangedAttack circle;

    public void OnSkill(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            ShootAttack(parabola);
        }
    }

    private void ShootAttack(IRanged rangedAttackType)
    {
        rangedAttack = rangedAttackType;
        rangedAttack.Shoot(bulletPrefab);
    }
}
