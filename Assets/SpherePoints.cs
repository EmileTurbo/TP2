using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Effects;

public class SpherePoints : MonoBehaviour
{
    public GameObject joueur;
    public TextMeshProUGUI nbrePoints;
    static int points;
    public GameObject particule;
    public TextMeshProUGUI victoire;

    // Start is called before the first frame update
    void Start()
    {
        nbrePoints.text = "Points : 0";
    }

    // Update is called once per frame
    void Update()
    {
        nbrePoints.text = "Points : " + points;

        if (points == 15)
        {
            StartCoroutine(Victoire());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "point")
        {
            Instantiate(particule, this.transform.position, Quaternion.identity); //On instancie une particule à la position de la sphere
            Destroy(other.gameObject);
            points++;
            
        }

        if (other.gameObject.tag == "nefaste")
        {

            points--;

        }

    }

    IEnumerator Victoire()
    {
        
        victoire.text = "Victoire";

        this.GetComponent<PlayerMouvement>().enabled = false;
        yield return new WaitForSeconds(3f);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("SceneMenu"); // Charge la scène SceneMenu
    }
}
