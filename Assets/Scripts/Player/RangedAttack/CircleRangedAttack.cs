using UnityEngine;

public class CircleRangedAttack : MonoBehaviour, IRanged
{
    public void Shoot(GameObject bullet)
    {
        Debug.Log("circle");
    }
}