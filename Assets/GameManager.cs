using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ゲームが開始したかどうか
    public static bool gameStarted = false;

    // タイトル文字
    public GameObject titleText;

    void Start()
    {
        gameStarted = false;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;

            titleText.SetActive(false);

            Time.timeScale = 1;
        }
    }
}