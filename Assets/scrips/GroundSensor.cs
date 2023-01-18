using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrounded;

   void OnTriggerEnter2D(Collider2D other)
   {
    isGrounded = true;
   }
   void OnTriggerExit2D(Collider2D other)
   {
    isGrounded = false;
   }
}
