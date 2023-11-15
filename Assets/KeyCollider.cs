using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCollider : MonoBehaviour
{
    public GameObject keyOnPlayer;
    public GameObject porte;
    bool isKey = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            keyOnPlayer.SetActive(true);
            isKey = true;
        }

        if(other.gameObject.tag == "porte")
        {
            if(isKey == true)
            {
                porte.SetActive(false);
                keyOnPlayer.SetActive(false);
                SceneManager.LoadScene("SceneReserve"); // Charge la scène SceneReserve
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
