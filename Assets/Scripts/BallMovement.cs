using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rgball;
    public float power = 500f;

    void Start() {
        int randomIndex = Random.Range(0, 4);
        float randomfloatIndex = Random.Range(45f, 130f);

        if (randomIndex >= 2)
        {
            rgball.AddForce(randomfloatIndex, 0, power);
        }
        if (randomIndex < 2)
        {
            rgball.AddForce(randomfloatIndex, 0, -power);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(rgball.velocity);
        if (rgball.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
