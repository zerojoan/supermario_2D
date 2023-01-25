using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
     int playerHealth = 3; 
     public float playerSeed= 5.5f;
     public float jumpForce = 3f;

     string texto = "Hello world";
     private SpriteRenderer SpriteRenderer;
     private Rigidbody2D rBody; 
     private GroundSensor sensor;
     public Animator anim;

     float horizontal;
    // Start is called before the first frame update                                                                                              
    void Start() 
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        rBody = GetComponent<Rigidbody2D>();
        playerHealth = 10;
        Debug.Log(texto);
        sensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, 0) * playerSeed* Time.deltaTime;

        if(horizontal <0)
        {
            SpriteRenderer.flipX = true;
            anim.SetBool("isRunning", true);
        }
        else if (horizontal > 0)
          {
            SpriteRenderer.flipX = false;
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if(Input.GetButtonDown("Jump") && sensor.isGrounded) 
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }
    }
}
