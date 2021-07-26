using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("è entrato " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("è uscito " + other.gameObject.name);
    }
}
