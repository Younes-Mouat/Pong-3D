using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text HighScoreText;
    public Text CurrentScoreText;
    public Text Thanks;
    private static int _myHighScore;


    void Start () {
        Thanks.text = "Thank you for playing " + Menu.Loadedname;
        HighScoreText.text += PlayerPrefs.GetInt("HighScore",0).ToString();
        CurrentScoreText.text += EGoal.PlayerScores.ToString();
    }


    public void Quit () {
        Debug.Log("Pong 3D is stopped");
        SceneManager.LoadScene("Menu");
    }

    public void Replay () {
        Debug.Log("Replay!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        EGoal.PlayerScores = 0;
        PGoal.EnemyScores = 0;
    }

    public void Leaderboard () {
        SceneManager.LoadScene("LeaderBoard");
    }
}

