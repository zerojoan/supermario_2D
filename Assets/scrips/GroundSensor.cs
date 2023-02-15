using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   private Playercontroller controller;

   public bool isGrounded;

   SFXManager sfxManager;
   private void Awake() 
   {
      controller = GetComponentInParent<Playercontroller>();
      sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
   }

   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.gameObject.layer == 3)
    {
      isGrounded = true;
      controller.anim.SetBool("isJumping", false);
    }
    else if (other.gameObject.layer == 6)
    {
      Debug.Log("Goomba muerto");
      sfxManager.GoombaDeath();
      Enemy goomba = other.gameObject.GetComponent<Enemie>();
      goomba.Die();
    }
   {
   void OnTriggerStay2D(Collider2D other)
   }
    
   {
    isGrounded = true;
   }
   void OnTriggerExit2D(Collider2D other)
   {
    isGrounded = false;
    controller.anim.SetBool("isJumping", false);
   }
}
