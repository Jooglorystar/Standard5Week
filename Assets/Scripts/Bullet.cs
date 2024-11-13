using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyBullet", 10f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
