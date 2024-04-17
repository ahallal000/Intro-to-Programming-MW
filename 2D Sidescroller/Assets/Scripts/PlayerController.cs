using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D playerBody;

    public float playerSpeed = 0.05f;
    public float jumpForce = 300;
    public bool isJumping = false;

    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBarScript;




    public bool flippedLeft;
    public bool facingLeft;
    void Start()
    {

        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Jump();
    }

    private void MovePlayer()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A pressed");
            newPos.x -= playerSpeed;
            flippedLeft = true;
            Flip(facingLeft);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D pressed");
            newPos.x += playerSpeed;
            flippedLeft = false;
            Flip(facingLeft);

        }
        transform.position = newPos;

    }

    private void Jump()
    {
        if (!isJumping && Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.AddForce(new Vector3(playerBody.velocity.x, jumpForce, 0));
            isJumping = true;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Surface")
        {
            isJumping = false;
        }

        if (collision.gameObject.tag == "Lava")
        {
            //currentHealth = currentHealth - 1;
            //Debug.Log("Lava Touched");
            TakeDamage(1);
        }

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBarScript.SetHealth(currentHealth);
    }



    void Flip(bool facingLeft)
    {
        if (facingLeft && !flippedLeft)
        {

            //Debug.Log("Facing Right");

            transform.Rotate(0, -180, 0);
            flippedLeft = true;
        }
        if(!facingLeft && flippedLeft)
        {
            //Debug.Log("Facing Left");

            transform.Rotate(0,-180, 0);
            flippedLeft = false;
        }

    }




}
