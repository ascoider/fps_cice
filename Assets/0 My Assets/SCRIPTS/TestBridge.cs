using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBridge : MonoBehaviour
{
    [SerializeField] Animator bridge;

    string currentButton;


    void Awake()
    {
        currentButton = gameObject.name;
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (currentButton == "BridgeOpener")
                bridge.SetBool("IsOpened", true);
            else if (currentButton == "BridgeCloser")
                bridge.SetBool("IsOpened", false);

        }
    }
}
