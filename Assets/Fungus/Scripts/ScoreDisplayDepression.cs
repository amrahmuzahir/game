using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayDepression : MonoBehaviour
{
    public ScoreManagerDepression scoreManagerDepression;
    public Text Scoring1;

    private void Start()
    {

        scoreManagerDepression = GameObject.FindObjectOfType<ScoreManagerDepression>();


        if (Scoring1 == null)
        {
            Debug.LogError("Text component reference is not set in ScoreDisplay script.");
        }
    }

    private void Update()
    {

        if (scoreManagerDepression != null && Scoring1 != null)
        {
            Scoring1.text = "Depression Score: " + scoreManagerDepression.GetScore().ToString() + "/5";
        }
    }
}

