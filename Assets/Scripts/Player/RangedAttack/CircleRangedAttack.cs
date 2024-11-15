using System.Collections.Generic;
using UnityEngine;

public class CircleRangedAttack : RangedAttacks
{
    [SerializeField] private int bulletCount;

    public override void Shoot(GameObject prefab)
    {
        Debug.Log("circle");

        for (int i = 0; i < bulletCount; i++)
        {
            GameObject bullet = Instantiate(prefab);
            bullet.GetComponent<Rigidbody>().velocity = CharacterManager.Instance.Player.transform.forward * bulletSpeed;
        }
    }
}