using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDoorOpen : MonoBehaviour
{
    public bool isInside; 
    [SerializeField] BoxCollider doorCollider;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isInside = true;
            doorCollider.isTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isInside = false;
            doorCollider.isTrigger = false;
        }
    }
}
