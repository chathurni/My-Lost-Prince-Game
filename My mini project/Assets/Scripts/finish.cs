using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{

    [SerializeField] private Key.KeyType keyType;

    private bool levelCompleted = false;

        // Start is called before the first frame update


    public Key.KeyType GetKeyType()
    {
        return keyType;

    }

    public void OpenDoor()
    {
        
        gameObject.SetActive(false);

        Invoke("CompleteLevel",2f);


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            
            levelCompleted = true;

        }
        
            
    }

    private void CompleteLevel ()
    {

        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex +1);
    }

}
