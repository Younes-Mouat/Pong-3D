using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PGoal : MonoBehaviour
{
    public static int EnemyScores;
    public static int HighScorevalue;

        void OnTriggerEnter (Collider other) {
            if (other.gameObject.tag == "Ball")
            {
                Debug.Log("Score");
                EnemyScores++;
                HighScorevalue =  GameManager.Instance.LoadData("HighScore",0);
                if (EGoal.PlayerScores > HighScorevalue)
                {
                    GameManager.Instance.SaveData("HighScore", EGoal.PlayerScores);
                    HighScorevalue =  GameManager.Instance.LoadData("HighScore",0);
                    //GameManager.Instance.SetScore(Menu.Loadedname,"highscore",HighScorevalue);
                }
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
}
