using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaderBoard : MonoBehaviour
{
    public GameObject ResultsPrefab;
    private int i = 1;

    void Update () {
        /*string[] playerNames = GameManager.Instance.GetPlayerNames("highscore");

        foreach (string playername in playerNames)
        {*/
            if (i == 1)
            {
                GameObject go = (GameObject)Instantiate(ResultsPrefab);
                go.transform.SetParent(this.transform);
                go.transform.Find("player_name").GetComponent<Text>().text = Menu.Loadedname;
                go.transform.Find("score_value").GetComponent<Text>().text = PGoal.HighScorevalue.ToString();
                i++;
            }
        //}
    }

    public void Return() {
        SceneManager.LoadScene("Menu");
    }
}
