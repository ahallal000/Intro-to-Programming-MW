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
        if (sceneNumber == 1) //if end scene
 
        {
            EndSceneControls(); //end scene controls apply
        }
    }


    public void EndSceneControls() //here are the end scene controls
    {
        //Debug.Log("end scene controls");
        if (Input.GetKeyDown(KeyCode.Space)) //if you press spacebar on end scene
        {
            SceneManager.LoadScene("Game Scene"); //then it takes you back to the game and restarts the game
        }
    }


    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID); //idk what this does ;-;
    }

}