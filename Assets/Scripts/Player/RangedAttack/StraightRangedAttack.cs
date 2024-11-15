using UnityEngine;

public class StraightRangedAttack : RangedAttacks
{
    public override void Shoot(GameObject prefab)
    {
        GameObject bullet = Instantiate(prefab);

        bullet.transform.position = skillPoint.position;

        bullet.GetComponent<Rigidbody>().velocity = CharacterManager.Instance.Player.transform.forward * bulletSpeed;
    }
}