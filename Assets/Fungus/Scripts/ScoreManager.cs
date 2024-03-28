using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public ScoreDisplay scoreDisplay;
    private int score = 0;
    public Text Scoring;
    public Text resultDisplay;

    private void Start()
    {
        ResetScore();
    }

    //Function to increase the score when the user selects "Most of the time"
    public void IncreaseScore()
    {
        score += 1;
        Debug.Log("Anxiety Score: " + score);

        //Update the score display
        UpdateScoreDisplay();

        //Save the score
        SaveScore();
    }


    private void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
    }


    public void LoadScore()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score");
            //Update the score display
            UpdateScoreDisplay();
        }
    }


    private void UpdateScoreDisplay()
    {
        if (Scoring != null)
        {
            Scoring.text = "Score: " + score;
        }
    }


    public void ResetScore()
    {
        score = 0;
        //Update the score display
        UpdateScoreDisplay();
        //Save the score after resetting
        SaveScore();
    }

    public int GetScore()
    {
        LoadScore();
        return score;
    }
}

   