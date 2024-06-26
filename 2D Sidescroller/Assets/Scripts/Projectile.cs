using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D projectileRb;

    public float speed = 5;


    public float projectileLife = 2;
    public float projectileCount;


    public PlayerController playerControllerScript;
    public bool facingLeft;

    // Start is called before the first frame update
    void Start()
    {
        projectileCount = projectileLife;

        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        facingLeft = playerControllerScript.facingLeft;

        if (!facingLeft)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //projectileRb.velocity = new Vector3(speed, projectileRb.velocity.y, 0);
        projectileCount -= Time.deltaTime;

        if (projectileCount <= 0) 
        {
        
           Destroy(gameObject);

        }


    }

    private void FixedUpdate()
    {
        if (!facingLeft)
        {
            projectileRb.velocity = new Vector3(speed, projectileRb.velocity.y, 0);
        }
        else
        {
            projectileRb.velocity = new Vector3(-speed, projectileRb.velocity.y, 0);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lava")
        {
            //Debug.Log("projectile hit lava");
            Destroy(collision.gameObject);


        }

        Destroy(gameObject);
    }



}
