using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{

    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray lastRay = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(lastRay, out hit,  10))
            {
                Debug.Log(hit.collider.gameObject.name);
                Debug.DrawRay(lastRay.origin, lastRay.direction * 10, Color.yellow);
            }
        }  
    }
}
