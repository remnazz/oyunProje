using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        { SceneManager.LoadScene(2); }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

}
