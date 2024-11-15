using UnityEngine;

public class CircleRangedAttack : RangedAttacks
{
    [SerializeField] private int bulletCount;
    private float radius = 1f;

    public override void Shoot(GameObject prefab)
    {
        for (int i = 0; i < bulletCount; i++)
        {
            float angle = i * Mathf.PI * 2f / bulletCount;
            Vector3 position = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius); 

            GameObject bullet = Instantiate(prefab, skillPoint.position + position, Quaternion.identity);
            bullet.transform.LookAt(skillPoint);

            bullet.GetComponent<Rigidbody>().velocity = -bullet.transform.forward * bulletSpeed;
        }
    }
}