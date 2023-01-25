using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   private PlayerController controller;

   public bool isGrounded;
   volid private void Awake() 
   {
      controller = GetComponentInparent<PlayerController>();
   }

   void OnTriggerEnter2D(Collider2D other)
   {
    isGrounded = true;
    controller.anim.SetBool("isJumping". false);
   }
    void OnTriggerStay2D(Collider2D other)
   {
    isGrounded = true;
   }
   void OnTriggerExit2D(Collider2D other)
   {
    isGrounded = false;
    controller.anim.SetBool("isJumping". false);
   }
}
