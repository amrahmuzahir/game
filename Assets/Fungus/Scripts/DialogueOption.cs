using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueOption : MonoBehaviour
{ 
    public Flowchart flowchart; 
    public ScoreManager scoreManager; 
   
    public void SelectOption()
    {
        flowchart.ExecuteBlock("OptionSelected"); 

        //Increase score if "Most of the time" option is selected
        scoreManager.IncreaseScore();
    }
}


