using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;

    public float spawnInterval = 2f;
    public float spawnDistance = 15f;

    private float timer = 0f;

    void Update()
    {
        if (!GameManager.gameStarted)
        {
            return;
        }

        if (ScoreManager.instance.score >= 20)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            Vector3 spawnPos =
                player.position
                + player.forward * spawnDistance
                + player.right * Random.Range(-12f, 12f);

            spawnPos.y = 0f;

            Instantiate(
                enemyPrefab,
                spawnPos,
                Quaternion.identity
            );

            timer = 0f;
        }
    }
}