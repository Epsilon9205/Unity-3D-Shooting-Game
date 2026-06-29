using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    public float speed = 5f;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime
        );
    }
}