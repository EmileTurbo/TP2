using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereNefaste : MonoBehaviour
{
    public GameObject joueur;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        joueur = GameObject.Find("Player"); //Initialiser le joueur avec notre hero
    }

    // Update is called once per frame
    private void Update()
    {
        if (GetDistance() < 0.9)
        {
            //Destruction de la sphere
            Instantiate(explosion, this.transform.position, Quaternion.identity); //On instancie une particule à la position de la sphere
            Destroy(this.gameObject);
        }

        if (GetDistance() < 3 )
        {
            transform.LookAt(joueur.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * 3f);
        }

        if (GetDistance() < 10)
        {
            GetComponent<Renderer>().material.color = Color.red;
            transform.LookAt(joueur.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * 1.5f);
        }

        if (GetDistance() > 10)
        {
            GetComponent<Renderer>().material.color = Color.white;

        }

    }

    private float GetDistance()
    {
        return Vector3.Distance(this.transform.position, joueur.transform.position);
    }
}
