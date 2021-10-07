using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{

    Player_Ctrl princess;

    // Start is called before the first frame update
    void Start()
    {
        princess = GetComponentInParent <Player_Ctrl> ();
    }

    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground") && princess.isJumping )
        {
            princess.isJumping = false;
        }
    }

   
}
