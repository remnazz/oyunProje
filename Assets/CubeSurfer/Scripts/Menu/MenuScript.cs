using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

   public void QuitButton()
    {
        Application.Quit();
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LevelUP()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        { SceneManager.LoadScene(2); }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

}
