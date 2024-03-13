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
        if (sceneNumber == 0)
        {
            StartSceneControls();
        } else if (sceneNumber == 1)
        {
            MainSceneControls();
        } else if (sceneNumber == 2)
        {
            EndSceneControls();
        }
    }


    public void StartSceneControls()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void MainSceneControls()
    {
        //Debug.Log("main scene controls");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("EndScene");
        }
    }


    public void EndSceneControls()
    {
        //Debug.Log("end scene controls");
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("StartScene");
        }
    }


    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
