using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime = 4f;
    public float homingPower = 1.5f;

    private Transform player;
    private Vector3 moveDirection;

    void Start()
    {
        player = GameObject.Find("Player").transform;

        moveDirection = (player.position - transform.position).normalized;

        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 targetDirection =
                (player.position - transform.position).normalized;

            moveDirection = Vector3.Lerp(
                moveDirection,
                targetDirection,
                homingPower * Time.deltaTime
            ).normalized;
        }

        transform.position += moveDirection * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHP playerHP = other.GetComponent<PlayerHP>();

            if (playerHP != null)
            {
                playerHP.TakeDamage(1);
            }

            Destroy(gameObject);
        }
    }
}