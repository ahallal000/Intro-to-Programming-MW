using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rbPaddle;
    public bool isPlayer1;
    public float paddleSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            Player1Control();
        }
        else
        {
            Player2Control();
        }
    }

    void Player1Control()
    {

        Vector3 newPos = transform.position;
        if (newPos.y <= 4.1f && newPos.y >= -4.1f)
        {

        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key pressed");
            newPos.y += paddleSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S key pressed");
            newPos.y -= paddleSpeed;
        }
        transform.position = newPos;



    }

    if (newPos.y >= 4.1f)
    {
        newPos.y = 4;
        transform.position = newPos;
    }
    else if (newPos.y <= -4.1f)
    {
        newPos.y = -4;
        transform.position = newPos;
    }
  
   
  }
    void Player2Control()
    {

    }

}