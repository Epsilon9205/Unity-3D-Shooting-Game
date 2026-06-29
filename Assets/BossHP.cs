using UnityEngine;

public class BossHP : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int hp = 20;
    public GameObject clearText;

    public void Damage(int value)
    {
        hp -= value;

        if (hp <= 0)
        {
            Instantiate(
                explosionPrefab,
                transform.position,
                Quaternion.identity
            );

           
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("BossBullet");

            foreach (GameObject bullet in bullets)
            {
                Destroy(bullet);
            }

            clearText.SetActive(true);

            Destroy(gameObject);
        }
    }
}