using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class InputHandler : MonoBehaviour
{
    

    public InputField inputText;
    public Text outputText;
    public Button textButton; 

    private void Start()
    {
        outputText.text = ""; 
    }

    public void processText()
    {
        outputText.text = Utilities.ProcessText(inputText.text); 
    }


}
