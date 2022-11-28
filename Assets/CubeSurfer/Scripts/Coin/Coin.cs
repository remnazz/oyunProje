using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            CoinText.coinAmount += 1;
            YourScore.yourScore = CoinText.coinAmount;
            Destroy(gameObject);
            if (BestScoreText.bestScore < CoinText.coinAmount)
            { BestScoreText.bestScore = CoinText.coinAmount; }
        }
    }
}
