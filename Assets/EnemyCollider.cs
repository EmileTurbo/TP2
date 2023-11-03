using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour
{
    public GameObject explosion;
    public TextMeshProUGUI gameOverText;
    public GameObject Player;
    public GameObject Decompte;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Decompte.SetActive(false);
            StartCoroutine(GameOver());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameOver()
    {
        gameOverText.text = "Game Over";
        this.GetComponent<PlayerMouvement>().enabled = false;
        yield return new WaitForSeconds(3f);

        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("SceneMenu"); // Charge la scène SceneMenu
    }
}
