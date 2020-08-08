using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
   public Rigidbody rb;
   public float sliding = 100f;

   void Update(){

       if (Input.GetKey("d"))
       {
           rb.AddForce(sliding,0,0);
       }

        if (Input.GetKey("a"))
       {
           rb.AddForce(-sliding,0,0);
       }
   }
}
