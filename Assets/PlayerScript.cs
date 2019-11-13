using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    bool isGrounded = false;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            HandleMovementUp();
        }

        if (Input.GetKey(KeyCode.D))
        {
            HandleMovmentR();
        }

        if (Input.GetKey(KeyCode.A))
        {
            HandleMovementL();
        }
    }

    private void HandleMovementUp()
    {
        myRigidbody.velocity = Vector2.up * 10.0f;
    }
    
    private void HandleMovmentR()
    {
        myRigidbody.velocity = new Vector2( (Vector2.right * 5.0f).x , myRigidbody.velocity.y);
    }

    
    private void HandleMovementL()
    {
        myRigidbody.velocity = new Vector2( (Vector2.left * 5.0f).x , myRigidbody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "ground")
        {
            isGrounded = true;
        }

    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "ground")
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.CompareTag("coins"))
        {
            scorecounter.coinAmount += 1;
            Destroy(other.gameObject);
        }
        
            
        

    }
}