using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{

    public void LoadScene (string level)
    {
        SceneManager.LoadScene(level);
    }
}
