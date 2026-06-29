using UnityEngine;

public class BossShoot : MonoBehaviour
{
    public GameObject bossBulletPrefab;
    public Transform player;

    public float shootInterval = 0.5f;

    private float timer = 0f;

    void Update()
    {
        if (!GameManager.gameStarted)
            return;

        timer += Time.deltaTime;

        if (timer >= shootInterval)
        {
            Vector3 spawnPos = transform.position;
            spawnPos.y = 0f;

            Instantiate(
                bossBulletPrefab,
                spawnPos,
                Quaternion.identity
            );

            timer = 0f;
        }
    }
}