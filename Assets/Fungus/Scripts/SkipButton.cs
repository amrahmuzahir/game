using UnityEngine;
using UnityEngine.UI;

public class SkipButton : MonoBehaviour
{
    
    public Fungus.Flowchart flowchart;

    //Function to be called when the skip button is clicked
    public void SkipCutscenes()
    {
      
        Debug.Log("Skip button clicked");


        flowchart.StopBlock("Start");
        flowchart.ExecuteBlock("AfterCutScene");
        
        SkipButton.Destroy(gameObject);
        

    }

    public void OnCutsceneEnd()
    {
        //Hide the skip button once the cutscene ends
        gameObject.SetActive(false);
    }
}
