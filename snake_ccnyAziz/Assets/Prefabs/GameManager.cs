using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI foodScoreText;
    public int foodscore = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //foodScoreText.text = "Score:" + foodscore;
    }


    public void FoodEaten()
    {
        foodscore++;
    }
}
    

