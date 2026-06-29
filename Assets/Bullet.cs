using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ScoreManager.instance.AddScore(1);

            Instantiate(
                explosionPrefab,
                collision.transform.position,
                Quaternion.identity
            );

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boss"))
        {
            other.GetComponent<BossHP>().Damage(1);

            Destroy(gameObject);
        }
    }
}