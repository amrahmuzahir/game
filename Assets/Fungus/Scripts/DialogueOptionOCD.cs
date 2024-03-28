using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueOptionOCD : MonoBehaviour
{
    public Flowchart flowchart1; 
    public ScoreManagerOCD scoreOCD; 

    public void SelectOption()
    {
        flowchart1.ExecuteBlock("OptionSelected"); 

        //Increase score if "Most of the time" option is selected
        scoreOCD.IncreaseScoreOCD();
    }
}


