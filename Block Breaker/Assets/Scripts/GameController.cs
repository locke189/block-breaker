using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    int currentScore;
    [SerializeField] TextMeshProUGUI scoreLabel;
    [SerializeField] int scorePerBlock = 10;
    

    private void Start()
    {
        currentScore = 0;
        scoreLabel.text = currentScore.ToString();
    }

    public void IncreaseScore() {
        currentScore += scorePerBlock;
        scoreLabel.text = currentScore.ToString();
    }

    public void ResetGame() {
        Destroy(gameObject);
    }
}
