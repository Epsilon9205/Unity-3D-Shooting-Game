using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int hp = 5;
    public TMP_Text hpText;
    public GameObject gameOverText;

    void Start()
    {
        hpText.text = "HP : " + hp;
    }

    public void TakeDamage(int damage)
    {
        
        if (hp <= 0)
            return;

        hp -= damage;

        if (hp < 0)
            hp = 0;

        hpText.text = "HP : " + hp;

        if (hp <= 0)
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}