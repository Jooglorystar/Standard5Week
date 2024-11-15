using UnityEngine;

public abstract class RangedAttacks : MonoBehaviour, IRanged
{
    [SerializeField] protected Transform skillPoint;
    protected float bulletSpeed = 10f;
    public abstract void Shoot(GameObject bullet);
}