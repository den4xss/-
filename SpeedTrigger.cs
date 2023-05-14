using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 9;
 
    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
 
    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
