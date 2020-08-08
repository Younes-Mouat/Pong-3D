using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public Rigidbody rbenemy;
    public Rigidbody rgball;
    public float sidewaysforce = 100f;

    void FixedUpdate () {

        if (rgball.position.z > 0f && rgball.position.x < -1.75f )
        {
            rbenemy.AddForce(-sidewaysforce,0,0);
        }

        if (rgball.position.z > 0f && rgball.position.x > 1.75f )
        {
            rbenemy.AddForce(sidewaysforce,0,0);
        }

        if (rgball.position.z > 0f && rgball.position.x >= -1.75f && rgball.position.x <= 1.75f)
        {
            if (rbenemy.position.x > 1f)
            {
                rbenemy.AddForce(-10f,0,0);
            }

            if (rbenemy.position.x < 1f)
            {
                rbenemy.AddForce(10f,0,0);
            }
        }
    } 

}
