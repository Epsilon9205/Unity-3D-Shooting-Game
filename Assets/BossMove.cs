using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float moveRange = 5f;
    public float moveSpeed = 2f;

    private Vector3 startPos;

    void OnEnable()
    {
        startPos = new Vector3(0f, 0f, 15f);
        transform.position = startPos;
    }

    void Update()
    {
        if (!GameManager.gameStarted)
        {
            return;
        }

        float x = Mathf.Sin(Time.time * moveSpeed) * moveRange;

        transform.position = new Vector3(
            startPos.x + x,
            startPos.y,
            startPos.z
        );
    }
}