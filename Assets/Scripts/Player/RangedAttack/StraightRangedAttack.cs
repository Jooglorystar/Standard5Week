using UnityEngine;

public class StraightRangedAttack : RangedAttacks
{
    public override void Shoot(GameObject prefab)
    {
        GameObject bullet = Instantiate(prefab);

        bullet.transform.position = skillPoint.position + (skillPoint.forward);
        bullet.transform.LookAt(skillPoint.position);

        bullet.GetComponent<Rigidbody>().velocity = -bullet.transform.forward * bulletSpeed;
    }
}