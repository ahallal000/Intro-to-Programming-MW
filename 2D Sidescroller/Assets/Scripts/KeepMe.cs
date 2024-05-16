using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMe : MonoBehaviour
{
    // Start is called before the first frame update


    public static GameObject instance;


    void Start()
    {
        
    }


    private void Awake()
    {
        if (instance == null)
        {
            Debug.Log("Audio Manager Not Destroyed");
            instance = gameObject;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Debug.Log("Extra Audio Manager Destroyed.");
            Destroy(gameObject);
        }

        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
