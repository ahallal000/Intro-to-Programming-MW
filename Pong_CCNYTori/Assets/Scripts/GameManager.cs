using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    private int player1Score = 0;
    private int player2Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1Scored()
    {
        player1Score++;
    }
    public void Player2Scored()
    {
        player2Score++;
    }
}
