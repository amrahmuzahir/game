using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueOptionDepression : MonoBehaviour
{
    public Flowchart flowchart; 
    public ScoreManagerDepression scoreDepression;

    public void SelectOption()
    {
        flowchart.ExecuteBlock("OptionSelected"); 

        //Increase score if "Most of the time" option is selected.
        scoreDepression.IncreaseScoreDepression();
    }
}


