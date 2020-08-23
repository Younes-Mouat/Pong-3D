using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    public Text PlayerPointsText;
    private static int _playerPoints;

    // Update is called once per frame
    void Update()
    {
        _playerPoints = EGoal.PlayerScores;
        PlayerPointsText.text = _playerPoints.ToString();
    }
}
