using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{

    public int gemValue = 1;


    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {

            
            Score_Manager .instance.ChangeScore (gemValue);
        }
    }


}
