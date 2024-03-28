using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayOCD : MonoBehaviour
{
    public ScoreManagerOCD scoreManagerOCD;
    public Text Scoring1;

    private void Start()
    {

        scoreManagerOCD = GameObject.FindObjectOfType<ScoreManagerOCD>();


        if (Scoring1 == null)
        {
            Debug.LogError("Text component reference is not set in ScoreDisplay script.");
        }
    }

    private void Update()
    {

        if (scoreManagerOCD != null && Scoring1 != null)
        {
            Scoring1.text = "OCD Score: " + scoreManagerOCD.GetScore().ToString() + "/3";
        }
    }
}

