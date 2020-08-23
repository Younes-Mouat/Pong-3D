using UnityEngine;
using UnityEngine.UI;

public class EnemyScore : MonoBehaviour
{
    public Text EnemyPointsText;
    private static int _enemyPoints;

    // Update is called once per frame
    void Update()
    {
        _enemyPoints = PGoal.EnemyScores;
        EnemyPointsText.text = _enemyPoints.ToString();
    }
}
