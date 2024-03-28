using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManagerOCD : MonoBehaviour
{
    public ScoreDisplayOCD scoreDisplayOCD;
    private int score1 = 0;
    public Text Scoring1;
    public DialogueOptionDepression dialogueOptionDepression;

    private void Start()
    {
        ResetScore();
    }

    //Function to increase the score when the user selects "Most of the time"
    public void IncreaseScoreOCD()
    {
        score1 += 1;
        Debug.Log("OCD Score: " + score1);

        //Update the score display
        UpdateScoreDisplayOCD();

        //Save the score
        SaveScore();
    }


    private void SaveScore()
    {
        PlayerPrefs.SetInt("ScoreOCD", score1);
        PlayerPrefs.Save();
    }

 
    public void LoadScore()
    {
        if (PlayerPrefs.HasKey("ScoreOCD"))
        {
            score1 = PlayerPrefs.GetInt("ScoreOCD");
            //Update the score display
            UpdateScoreDisplayOCD();
        }
    }

    //Update the score display if it's assigned
    private void UpdateScoreDisplayOCD()
    {
        if (Scoring1 != null)
        {

            Scoring1.text = "OCD Score: " + score1;
        }
    }

 
    public void ResetScore()
    {
        score1 = 0;
        //Update the score display
        UpdateScoreDisplayOCD();
        //Save the score after resetting
        SaveScore();
    }

    public int GetScore()
    {
        LoadScore();
        return score1;
    }

}
