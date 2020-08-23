using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour
{
    bool gameisover = false;
    public static GameManager Instance;
    private Dictionary<string, Dictionary<string, int> > ScoreBoard;

    

    public void GameOver () {
        if (gameisover == false)
        {
            gameisover = true;
            Debug.Log("Game OVER");
            Invoke("_restart", 1f);
        }
        
    }

    private void _restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    //Instance.GetComponent<GameManager>();

    public void SaveData (string key,int value) {
        PlayerPrefs.SetInt(key,value);
        PlayerPrefs.Save();
    }

    public int LoadData (string key, int defualtvalue) {
        return PlayerPrefs.GetInt(key,defualtvalue);
    }

    public void SaveStringData (string key, string name) {
        PlayerPrefs.SetString(key, name);
        PlayerPrefs.Save();
    }

    public string LoadStringData (string key) {
        return PlayerPrefs.GetString(key);
    } 


    //LeaderBoard

    

    /*public void Initiate () {
        ScoreBoard = new Dictionary<string, Dictionary<string, int>>();
    }*/

    public int GetScore(string playername, string highscore) {
        if (ScoreBoard[playername].ContainsKey(highscore) == false)
        {
            ScoreBoard[playername] = new Dictionary<string, int>();
        }

        return ScoreBoard[playername][highscore];
    }

    public void SetScore (string playername, string highscore, int scorevalue) {
        ScoreBoard[playername][highscore] = scorevalue;
    }

    public void UpdateScore (string playername, string highscore, int scorevalue, int currentscore) {
        if (currentscore > scorevalue)
        {
            ScoreBoard[playername][highscore] = currentscore;
        }
    }

    
    void Awake(){
        
        if (Instance != null)
        {
            Destroy(this);
        }

        if (Instance == null)
        {
            Instance = this;    
        
        }
    }
}
