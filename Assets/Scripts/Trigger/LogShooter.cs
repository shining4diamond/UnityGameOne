using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogShooter : MonoBehaviour
{
    public void ShootLog(string message)
    {
        Debug.Log("Shooting: " + message);
    }
}
