using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float paddleWidth = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        xPos = Mathf.Clamp(xPos, 0, screenWidthInUnits - paddleWidth);
        transform.position = new Vector2(xPos, transform.position.y);
    }
}
