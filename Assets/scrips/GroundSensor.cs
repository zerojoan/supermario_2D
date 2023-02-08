using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   private Playercontroller controller;

   public bool isGrounded;
   private void Awake() 
   {
      controller = GetComponentInParent<Playercontroller>();
   }

   void OnTriggerEnter2D(Collider2D other)
   {
    isGrounded = true;
    controller.anim.SetBool("isJumping", false);
   }
    void OnTriggerStay2D(Collider2D other)
   {
    isGrounded = true;
   }
   void OnTriggerExit2D(Collider2D other)
   {
    isGrounded = false;
    controller.anim.SetBool("isJumping", false);
   }
}
