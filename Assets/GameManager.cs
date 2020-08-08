using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameisover = false;

    public void GameOver () {
        if (gameisover == false)
        {
            gameisover = true;
            Debug.Log("Game OVER");
            Invoke("Restart", 1f);
        }
        
    }
    void Restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
