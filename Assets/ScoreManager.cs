using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public TMP_Text scoreText;
    public GameObject boss;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = "SCORE : 0";
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "SCORE : " + score;
        if (score >= 20 && !boss.activeSelf)
        {
            boss.SetActive(true);
        }
    }
}