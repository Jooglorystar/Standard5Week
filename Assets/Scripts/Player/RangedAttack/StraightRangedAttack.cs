using UnityEngine;

public class StraightRangedAttack : MonoBehaviour, IRanged
{
    [SerializeField] Transform skillPoint;


    public void Shoot(GameObject prefab)
    {
        GameObject bullet = Instantiate(prefab);

        bullet.transform.position = skillPoint.position;


        bullet.GetComponent<Rigidbody>().velocity = CharacterManager.Instance.Player.transform.forward * 10f;
    }
}