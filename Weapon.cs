using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;


    public void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position,FirePoint.rotation);
    }
}
