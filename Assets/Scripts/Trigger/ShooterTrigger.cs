using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTrigger : MonoBehaviour
{

    public GameObject logShooterObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            LogShooter logShooter = logShooterObject.GetComponent<LogShooter>();
            if(logShooter != null)
            {
                logShooter.ShootLog("Ciao");
            }

        }
        
    }
}
