using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    private void OnCollision(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            SceneManager.LoadScene(2);
            if (SceneManager.GetActiveScene().buildIndex == 1)
            { SceneManager.LoadScene(2); }
            else
            { SceneManager.LoadScene(1); }
        }
    }




}
