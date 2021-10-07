using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score_Manager : MonoBehaviour
{
    public static Score_Manager instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }
    
    public void ChangeScore (int gemValue)
    {
        score += gemValue;
        text.text = "X"+score.ToString ();
    }

   
}
