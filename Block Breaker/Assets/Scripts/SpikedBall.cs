using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBall : MonoBehaviour
{
    [SerializeField] Paddle paddle0;
    [SerializeField] float verticalOffset = 1f;
    [SerializeField] float horizontalOffset = 1.5f;
    [SerializeField] float initialSpeed = 12f;
    bool hasStarted;

    void Start()
    {
        initializeBall();
    }


    void Update()
    {
        if (!hasStarted)
        {
            SetAttachedPosition();
            if (Input.GetMouseButtonDown(0)) {
                LaunchBall();
                hasStarted = true;
            }
        }
    }

    void initializeBall() {
        hasStarted = false;
    }

    void SetAttachedPosition() {
        Vector2 offset = new Vector2(horizontalOffset, verticalOffset);
        Vector2 paddlePos = new Vector2(paddle0.transform.position.x, paddle0.transform.position.y);
        transform.position = paddlePos + offset;
    }

    void LaunchBall() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, initialSpeed);
    }
}
