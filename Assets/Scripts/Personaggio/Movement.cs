using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 1;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se premo il pulsante
        //muovi l'oggetto sull'asse corrispondente al tasto
        //"Horizontal"

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0, 0, 0);

        if (horizontalMovement != 0)
        {
            
            direction.z = horizontalMovement;

        }
        if (verticalMovement != 0)
        {
            direction.x = verticalMovement * -1;
        }

        transform.Translate(direction * (speed * Time.deltaTime));

    }
}
