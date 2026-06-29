using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet =
                Instantiate(
                    bulletPrefab,
                    shootPoint.position,
                    shootPoint.rotation
                );

            Rigidbody rb =
                bullet.GetComponent<Rigidbody>();

            rb.linearVelocity =
                shootPoint.forward * bulletSpeed;
        }
    }
}