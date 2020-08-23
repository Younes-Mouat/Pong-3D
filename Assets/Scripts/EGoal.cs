using UnityEngine;


public class EGoal : MonoBehaviour
{
    public static int PlayerScores;
    
        void OnTriggerEnter (Collider other) {
            if (other.tag == "Ball")
            {
                PlayerScores++;
            }
        }


}
