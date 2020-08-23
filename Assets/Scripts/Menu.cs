using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text Score;
    public Text PlayerNameText;
    public GameObject Inputfield;
    public string playername;
    public static string Loadedname;

    void Start () {
        Score.text += PlayerPrefs.GetInt("HighScore",0).ToString();
        //PlayerPrefs.DeleteAll();
    }

    public void StartGame() {
        EGoal.PlayerScores = 0;
        PGoal.EnemyScores = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit () {
        Application.Quit();
    } 

    public void Leaderboard () {
        SceneManager.LoadScene("LeaderBoard");
    }

    public void AddName () {
        playername = Inputfield.GetComponent<Text>().text;
        GameManager.Instance.SaveStringData("PlayerName", playername);
        Loadedname = GameManager.Instance.LoadStringData("PlayerName").ToString();
        PlayerNameText.text = "Hello " + Loadedname + " to Pong 3D";
        
    }
}
