using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    GameObject cubePrefab;

    int x1  =   -5;
    int x2  =   5;
    int y1  =   -5;
    int y2  =   5;
    int z1  =   -5;
    int z2  =   5;
    
    // Start is called before the first frame update sdffdsf
    void Start()
    {
        Debug.Log(gameObject.name + ": \"Sono spawnato\" ", gameObject);
        

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonUp(0))
        {
            int x   =   Random.Range(x1,x2);
            int y   =   Random.Range(y1,y2);
            int z   =   Random.Range(z1,z2);
            Instantiate (   cubePrefab
                        ,   new Vector3 (
                                        x
                                    ,   y
                                    ,   z
                                        )
                        ,   cubePrefab.transform.rotation
                        );
        }
        
    }
}
