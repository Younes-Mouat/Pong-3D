using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody rgball;
    public float force = 700f;

    void OnCollisionEnter(Collision collisioninfo){
        if (collisioninfo.collider.tag == "Obstacle")
        {
            //Debug.Log("we hit enemy");

            if (rgball.position.z > 0f)
            {
                rgball.AddForce(0,0,-force);
            }
            
            if (rgball.position.z < -0f)
            {
                rgball.AddForce(0,0,force);
            }

        }
    }
}
