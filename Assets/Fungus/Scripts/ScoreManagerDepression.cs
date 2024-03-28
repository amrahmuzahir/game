using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManagerDepression : MonoBehaviour
{
    public ScoreDisplayDepression scoreDisplayDepression;
    private int score1 = 0;
    public Text Scoring1;
    public DialogueOptionDepression dialogueOptionDepression;

    private void Start()
    {
        ResetScore();
    }

    //Function to increase the score when the user selects "Most of the time"
    public void IncreaseScoreDepression()
    {
        score1 += 1;
        Debug.Log("Depression Score: " + score1);

        //Update the score display
        UpdateScoreDisplayDepression();

    
        SaveScore();
    }

    
    private void SaveScore()
    {
        PlayerPrefs.SetInt("ScoreDepression", score1);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        if (PlayerPrefs.HasKey("ScoreDepression"))
        {
            score1 = PlayerPrefs.GetInt("ScoreDepression");
            UpdateScoreDisplayDepression();
        }
    }

    
    private void UpdateScoreDisplayDepression()
    {
        if (Scoring1 != null)
        {
      
            Scoring1.text = "Depression Score: " + score1;
        }
    }

   
    public void ResetScore()
    {
        score1 = 0;
        //Update the score display
        UpdateScoreDisplayDepression();
        //Save the score after resetting
        SaveScore();
    }

    public int GetScore()
    {
        LoadScore();
        return score1;
    }

}
