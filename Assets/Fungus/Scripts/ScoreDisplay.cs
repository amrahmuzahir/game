using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public ScoreManager scoreManager; 
    public Text Scoring; 

    private void Start()
    {

        scoreManager = GameObject.FindObjectOfType<ScoreManager>();

     
        if (Scoring == null)
        {
            Debug.LogError("Text component reference is not set in ScoreDisplay script.");
        }
    }
     
    private void Update()
    {
        
        if (scoreManager != null && Scoring != null)
        {
            Scoring.text = "Anxiety Score: " + scoreManager.GetScore().ToString() + "/8";
        }
    }
}
