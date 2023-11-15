using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Decompte : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 60f;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI gameOverText;
    public GameObject Player;
    

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
            StartCoroutine(GameOver());
        }

    }

    IEnumerator GameOver()
    {
        currentTime = 0;
        gameOverText.text = "Game Over";

        Player.SetActive(false);

        yield return new WaitForSeconds(3f);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("SceneMenu"); // Charge la scène SceneMenu
    }
}
