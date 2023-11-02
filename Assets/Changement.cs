using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changement : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("SceneLab"); // Charge la scène SceneLab
    }

    // Update is called once per frame
    public void Quitter()
    {
        Application.Quit(); // Quitte l'application
    }
}
