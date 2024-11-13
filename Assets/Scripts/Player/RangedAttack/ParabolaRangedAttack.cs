using UnityEngine;

public class ParabolaRangedAttack : MonoBehaviour, IRanged
{
    [SerializeField] Transform skillPoint;

    public void Shoot(GameObject prefab)
    {
        Debug.Log("parabola");
        GameObject bullet = Instantiate(prefab);

        bullet.transform.position = skillPoint.position;

        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.constraints &= ~RigidbodyConstraints.FreezePositionY;
        bulletRb.velocity = (CharacterManager.Instance.Player.transform.forward+ CharacterManager.Instance.Player.transform.up).normalized * 10f;
    }
}