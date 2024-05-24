using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public int sceneNumber;
    //0 = StartScene
    //1 = MainScene
    //2 = EndScene

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber == 2) //if end scene

        {
            EndSceneControls(); //end scene controls apply
        }

        if (sceneNumber == 0)
        {
            StartSceneControls();
        }

    }


    public void EndSceneControls() //here are the end scene controls
    {
        //Debug.Log("end scene controls");
        if (Input.GetKeyDown(KeyCode.Space)) //if you press spacebar on end scene
        {
            Debug.Log("space pressed");
            SceneManager.LoadScene(1); //then it takes you back to the game and restarts the game
        }
        if(Input.GetKeyDown(KeyCode.W)) //if you press spacebar on end scene
        {
            //Debug.Log("space pressed");
            SceneManager.LoadScene(0); //then it takes you back to the game and restarts the game
        }
    }

    public void StartSceneControls()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }



    }


    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID); //idk what this does ;-;
    }

}