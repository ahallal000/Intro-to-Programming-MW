using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{


    public bool isPlayer1Goal;
    public GameManager myManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTiggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            myManager.Player2Scored();
        }
        else
        {
            myManager.Player1Scored();
        }
    }       
}
