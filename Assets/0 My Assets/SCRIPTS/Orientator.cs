using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientator : MonoBehaviour
{
    Transform target;


    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(target);
    }
}
