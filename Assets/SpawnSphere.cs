using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            lancerSphere();
        }
            
    }

    private void lancerSphere()
    {
        float x = UnityEngine.Random.Range(-25f, 100f);
        float z = UnityEngine.Random.Range(10f, 130f);

        Terrain terrain = Terrain.activeTerrain;
        

        Vector3 position = new Vector3(x, 0, z);

        float hauteurTerrain = terrain.SampleHeight(position);

        Vector3 positionSphere = new Vector3(x, hauteurTerrain-9.5f, z);
        Instantiate(sphere, positionSphere, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
