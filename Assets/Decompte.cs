using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Decompte : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI gameOverText;
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0 )
        {
            currentTime = 0;
            gameOverText.text = "Game Over";
            
        }

    }
}
