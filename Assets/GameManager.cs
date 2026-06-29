using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameStarted = false;

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name
            );
        }
    }
}