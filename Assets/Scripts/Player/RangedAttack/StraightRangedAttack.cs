using UnityEngine;

public class StraightRangedAttack : MonoBehaviour, IRanged
{
    [SerializeField] Transform skillPoint;


    public void Shoot(GameObject prefab)
    {
        Debug.Log("straight");
        GameObject bullet = Instantiate(prefab);
        bullet.transform.position = skillPoint.position;
        bullet.transform.position += CharacterManager.Instance.Player.transform.forward;
        bullet.GetComponent<Rigidbody>().velocity = CharacterManager.Instance.Player.transform.forward * 10f;
        bullet.transform.rotation =
            Quaternion.Euler(
                -CharacterManager.Instance.Player.controller.camCurXRot,
                CharacterManager.Instance.Player.transform.rotation.y,
                0f
                );

    }
}