using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    public GameObject CanvasVictory;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {

            Debug.Log("Victory");

            PlayerBehaviour.Instance.VictoryAnimation();

            PlayerBehaviour.Instance.StopPlayer();

            CanvasVictory.SetActive(true);
      

        }

    }


}
