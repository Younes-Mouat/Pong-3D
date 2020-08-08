using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rgball;
    public float power;

    void OnCollisionEnter(Collision collisioninfo){
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Debug.Log("we hit enemy");

            if (rgball.position.z > 0f)
            {
                rgball.AddForce(0,0,-800);
            }
            
            if (rgball.position.z < -0f)
            {
                rgball.AddForce(0,0,800);
            }

        }
    }
}
