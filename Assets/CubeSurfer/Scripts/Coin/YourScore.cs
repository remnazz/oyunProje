using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScore : MonoBehaviour
{
    Text text;
    public static int yourScore;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = yourScore.ToString();
    }
}
