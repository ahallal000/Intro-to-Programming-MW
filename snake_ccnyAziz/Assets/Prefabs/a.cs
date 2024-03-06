using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using System.Linq;
using UnityEditor;

public class a : MonoBehaviour
{


    Vector3 dir = Vector3.right;




    List<Transform> tail = new List<Transform>();
    bool ate = false;
    public GameObject tailPrefab;

    public GameManager myManager;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveSnake", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeDirection();






        



    }

    void MoveSnake()
    {
        Vector3 gap = transform.position; 

        transform.Translate(dir);


        if (ate)
        {
            Debug.Log("ate =" + ate);

            GameObject tailSec = (GameObject)Instantiate(tailPrefab, gap, Quaternion.identity);

            tail.Insert(0, tailSec.transform);

            ate = false;
        }

         else if (tail.Count > 0)
        {
            tail.Last().position = gap;

            tail.Insert(0, tail.Last());

            tail.RemoveAt(tail.Count - 1);
        }
    }

    private void ChangeDirection()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            dir= Vector3.right;
        }
        else if (Input.GetKey(KeyCode.DownArrow)) 
        {
            dir= Vector3.down;
        }
        else if (Input.GetKey(KeyCode.UpArrow)) 
        {
            dir= Vector3.up;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            ate = true;

            //Debug.Log("food eaten");
            Destroy(collision.gameObject);

            myManager.FoodEaten();
        }

        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Wall hit!!");
        }
    }
}

